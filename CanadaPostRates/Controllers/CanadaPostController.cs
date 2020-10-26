using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;
using CanadaPostRates.Models;

namespace CanadaPostRates.Controllers
{
    public class CanadaPostController : Controller
    {

        private FinalPrice GetRates(SourceDestination sourceDestination)
        {
            FinalPrice finalPrice = new FinalPrice();
            List<rate> finalRate = new List<rate>();

            var url = "https://ct.soa-gw.canadapost.ca/rs/ship/price"; // REST URL

            var method = "POST"; // HTTP Method
            String responseAsString = "";

            // Create mailingScenario object to contain xml request
            mailingscenario mailingScenario = new mailingscenario();
            mailingScenario.parcelcharacteristics = new mailingscenarioParcelcharacteristics();
            mailingScenario.destination = new mailingscenarioDestination();
            mailingscenarioDestinationDomestic destDom = new mailingscenarioDestinationDomestic();
            mailingScenario.destination.Item = destDom;


            String modifiedOrigin = Regex.Replace(sourceDestination.originpostalcode, @"\s", "");
            String modifiedDestination = Regex.Replace(sourceDestination.destinationpostalcode, @"\s", "");

            // Populate mailingScenario object
            mailingScenario.customernumber = "2004381";
            mailingScenario.parcelcharacteristics.weight = sourceDestination.parcelweight;
            mailingScenario.originpostalcode = modifiedOrigin.Trim();
            destDom.postalcode = modifiedDestination.Trim();

            try
            {

                // Serialize mailingScenario object to String
                StringBuilder mailingScenarioSb = new StringBuilder();
                XmlWriter mailingScenarioXml = XmlWriter.Create(mailingScenarioSb);
                mailingScenarioXml.WriteProcessingInstruction("xml", "version=\"1.1\" encoding=\"UTF-8\"");
                XmlSerializer serializerRequest = new XmlSerializer(typeof(mailingscenario));
                serializerRequest.Serialize(mailingScenarioXml, mailingScenario);

                // Create REST Request
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = method;

                // Set Basic Authentication Header using username and password variables
                string auth = "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes("6e93d53968881714" + ":" + "0bfa9fcb9853d1f51ee57a"));
                request.Headers = new WebHeaderCollection();
                request.Headers.Add("Authorization", auth);

                // Write Post Data to Request
                UTF8Encoding encoding = new UTF8Encoding();
                byte[] buffer = encoding.GetBytes(mailingScenarioSb.ToString());
                request.ContentLength = buffer.Length;
                request.Headers.Add("Accept-Language", "en-CA");
                request.Accept = "application/vnd.cpc.ship.rate-v4+xml";
                request.ContentType = "application/vnd.cpc.ship.rate-v4+xml";
                Stream PostData = request.GetRequestStream();
                PostData.Write(buffer, 0, buffer.Length);
                PostData.Close();

                // Execute REST Request
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode.ToString() == "OK")
                {
                    // Deserialize response to pricequotes object
                    XmlSerializer serializer = new XmlSerializer(typeof(pricequotes));
                    TextReader reader = new StreamReader(response.GetResponseStream());
                    pricequotes priceQuotes = (pricequotes)serializer.Deserialize(reader);

                    // Retrieve values from pricequotes object
                    foreach (var priceQuote in priceQuotes.pricequote)
                    {
                        finalRate.Add(new rate { RegularPrice = priceQuote.pricedetails.due, ServiceType = priceQuote.servicename, TransitDay = Convert.ToInt16(priceQuote.servicestandard.expectedtransittime) });

                    }
                    finalPrice.RatesList = finalRate;
                    finalPrice.originpostalcode = sourceDestination.originpostalcode;
                    finalPrice.destinationpostalcode = sourceDestination.destinationpostalcode;
                    finalPrice.parcelweight = sourceDestination.parcelweight;
                }
                else
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(messages));
                    TextReader reader = new StreamReader(response.GetResponseStream());
                    messages myMessages = (messages)serializer.Deserialize(reader);


                    if (myMessages.message != null)
                    {
                        foreach (var item in myMessages.message)
                        {
                            responseAsString += "Error Code: " + item.code + "\r\n";
                            responseAsString += "Error Msg: " + item.description + "\r\n";
                            ViewBag.ErrorMessage = responseAsString;
                        }
                    }
                }

            }
            catch (WebException webEx)
            {
                HttpWebResponse response = (HttpWebResponse)webEx.Response;

                if (response != null)
                {
                    //responseAsString += "HTTP  Response Status: " + webEx.Message + "\r\n";

                    // Retrieve errors from messages object
                    try
                    {
                        // Deserialize xml response to messages object
                        XmlSerializer serializer = new XmlSerializer(typeof(messages));
                        TextReader reader = new StreamReader(response.GetResponseStream());
                        messages myMessages = (messages)serializer.Deserialize(reader);


                        if (myMessages.message != null)
                        {
                            foreach (var item in myMessages.message)
                            {
                                responseAsString += "Error Code: " + item.code + "\r\n";
                                responseAsString += "Error Msg: " + item.description + "\r\n";
                                ViewBag.ErrorMessage = responseAsString;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Misc Exception
                        responseAsString += "ERROR: " + ex.Message;
                        ViewBag.ErrorMessage = responseAsString;
                    }
                }
                else
                {
                    // Invalid Request
                    responseAsString += "ERROR: " + webEx.Message;
                    ViewBag.ErrorMessage = responseAsString;
                }

            }
            catch (Exception ex)
            {
                // Misc Exception
                responseAsString += "ERROR: " + ex.Message;
                ViewBag.ErrorMessage = responseAsString;
            }

            return finalPrice;

        }

        // GET: CanadaPost
        public ActionResult Index()
        {
            return View();
        }

        // POST: CanadaPost
        [HttpPost]
        public ActionResult Index(SourceDestination sourceDestination)
        {
            if (!ModelState.IsValid)
            {
                return View();

            }
            FinalPrice ratesList = GetRates(sourceDestination);
            return View("Price", ratesList);

        }

        // GET: Price
        public ActionResult Price(FinalPrice ratesList)
        {
            if (ratesList.RatesList == null)
            {
                return RedirectToAction("Index");
            }

            if (ratesList.RatesList.Count() < 0)
            {
                return RedirectToAction("Index");
            }

            return View(ratesList);

        }

    }
}