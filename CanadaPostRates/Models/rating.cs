﻿
using System.Xml.Serialization;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.canadapost.ca/ws/ship/rate-v4", IsNullable = false)]
public partial class links
{

    private LinkType[] linkField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("link")]
    public LinkType[] link
    {
        get
        {
            return this.linkField;
        }
        set
        {
            this.linkField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
[System.Xml.Serialization.XmlRootAttribute("link", Namespace = "http://www.canadapost.ca/ws/ship/rate-v4", IsNullable = false)]
public partial class LinkType
{

    private string hrefField;

    private string relField;

    private string indexField;

    private string mediatypeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string href
    {
        get
        {
            return this.hrefField;
        }
        set
        {
            this.hrefField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string rel
    {
        get
        {
            return this.relField;
        }
        set
        {
            this.relField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
    public string index
    {
        get
        {
            return this.indexField;
        }
        set
        {
            this.indexField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("media-type", DataType = "normalizedString")]
    public string mediatype
    {
        get
        {
            return this.mediatypeField;
        }
        set
        {
            this.mediatypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
public partial class TaxType
{

    private decimal percentField;

    private bool percentFieldSpecified;

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal percent
    {
        get
        {
            return this.percentField;
        }
        set
        {
            this.percentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool percentSpecified
    {
        get
        {
            return this.percentFieldSpecified;
        }
        set
        {
            this.percentFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
[System.Xml.Serialization.XmlRootAttribute("mailing-scenario", Namespace = "http://www.canadapost.ca/ws/ship/rate-v4", IsNullable = false)]
public partial class mailingscenario
{

    private string customernumberField;

    private string contractidField;

    private string promocodeField;

    private mailingscenarioQuotetype quotetypeField;

    private bool quotetypeFieldSpecified;

    private System.DateTime expectedmailingdateField;

    private bool expectedmailingdateFieldSpecified;

    private mailingscenarioOption[] optionsField;

    private mailingscenarioParcelcharacteristics parcelcharacteristicsField;

    private string[] servicesField;

    private string originpostalcodeField;

    private mailingscenarioDestination destinationField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("customer-number")]
    public string customernumber
    {
        get
        {
            return this.customernumberField;
        }
        set
        {
            this.customernumberField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("contract-id")]
    public string contractid
    {
        get
        {
            return this.contractidField;
        }
        set
        {
            this.contractidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("promo-code", DataType = "normalizedString")]
    public string promocode
    {
        get
        {
            return this.promocodeField;
        }
        set
        {
            this.promocodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("quote-type")]
    public mailingscenarioQuotetype quotetype
    {
        get
        {
            return this.quotetypeField;
        }
        set
        {
            this.quotetypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool quotetypeSpecified
    {
        get
        {
            return this.quotetypeFieldSpecified;
        }
        set
        {
            this.quotetypeFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("expected-mailing-date", DataType = "date")]
    public System.DateTime expectedmailingdate
    {
        get
        {
            return this.expectedmailingdateField;
        }
        set
        {
            this.expectedmailingdateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool expectedmailingdateSpecified
    {
        get
        {
            return this.expectedmailingdateFieldSpecified;
        }
        set
        {
            this.expectedmailingdateFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("option", IsNullable = false)]
    public mailingscenarioOption[] options
    {
        get
        {
            return this.optionsField;
        }
        set
        {
            this.optionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("parcel-characteristics")]
    public mailingscenarioParcelcharacteristics parcelcharacteristics
    {
        get
        {
            return this.parcelcharacteristicsField;
        }
        set
        {
            this.parcelcharacteristicsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("service-code", DataType = "normalizedString", IsNullable = false)]
    public string[] services
    {
        get
        {
            return this.servicesField;
        }
        set
        {
            this.servicesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("origin-postal-code")]
    public string originpostalcode
    {
        get
        {
            return this.originpostalcodeField;
        }
        set
        {
            this.originpostalcodeField = value;
        }
    }

    /// <remarks/>
    public mailingscenarioDestination destination
    {
        get
        {
            return this.destinationField;
        }
        set
        {
            this.destinationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
public enum mailingscenarioQuotetype
{

    /// <remarks/>
    commercial,

    /// <remarks/>
    counter,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
public partial class mailingscenarioOption
{

    private string optioncodeField;

    private decimal optionamountField;

    private bool optionamountFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("option-code", DataType = "normalizedString")]
    public string optioncode
    {
        get
        {
            return this.optioncodeField;
        }
        set
        {
            this.optioncodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("option-amount")]
    public decimal optionamount
    {
        get
        {
            return this.optionamountField;
        }
        set
        {
            this.optionamountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool optionamountSpecified
    {
        get
        {
            return this.optionamountFieldSpecified;
        }
        set
        {
            this.optionamountFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
public partial class mailingscenarioParcelcharacteristics
{

    private decimal weightField;

    private mailingscenarioParcelcharacteristicsDimensions dimensionsField;

    private bool unpackagedField;

    private bool unpackagedFieldSpecified;

    private bool mailingtubeField;

    private bool mailingtubeFieldSpecified;

    private bool oversizedField;

    private bool oversizedFieldSpecified;

    /// <remarks/>
    public decimal weight
    {
        get
        {
            return this.weightField;
        }
        set
        {
            this.weightField = value;
        }
    }

    /// <remarks/>
    public mailingscenarioParcelcharacteristicsDimensions dimensions
    {
        get
        {
            return this.dimensionsField;
        }
        set
        {
            this.dimensionsField = value;
        }
    }

    /// <remarks/>
    public bool unpackaged
    {
        get
        {
            return this.unpackagedField;
        }
        set
        {
            this.unpackagedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool unpackagedSpecified
    {
        get
        {
            return this.unpackagedFieldSpecified;
        }
        set
        {
            this.unpackagedFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("mailing-tube")]
    public bool mailingtube
    {
        get
        {
            return this.mailingtubeField;
        }
        set
        {
            this.mailingtubeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mailingtubeSpecified
    {
        get
        {
            return this.mailingtubeFieldSpecified;
        }
        set
        {
            this.mailingtubeFieldSpecified = value;
        }
    }

    /// <remarks/>
    public bool oversized
    {
        get
        {
            return this.oversizedField;
        }
        set
        {
            this.oversizedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool oversizedSpecified
    {
        get
        {
            return this.oversizedFieldSpecified;
        }
        set
        {
            this.oversizedFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
public partial class mailingscenarioParcelcharacteristicsDimensions
{

    private decimal lengthField;

    private decimal widthField;

    private decimal heightField;

    /// <remarks/>
    public decimal length
    {
        get
        {
            return this.lengthField;
        }
        set
        {
            this.lengthField = value;
        }
    }

    /// <remarks/>
    public decimal width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    public decimal height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
public partial class mailingscenarioDestination
{

    private object itemField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("domestic", typeof(mailingscenarioDestinationDomestic))]
    [System.Xml.Serialization.XmlElementAttribute("international", typeof(mailingscenarioDestinationInternational))]
    [System.Xml.Serialization.XmlElementAttribute("united-states", typeof(mailingscenarioDestinationUnitedstates))]
    public object Item
    {
        get
        {
            return this.itemField;
        }
        set
        {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
public partial class mailingscenarioDestinationDomestic
{

    private string postalcodeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("postal-code")]
    public string postalcode
    {
        get
        {
            return this.postalcodeField;
        }
        set
        {
            this.postalcodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
public partial class mailingscenarioDestinationInternational
{

    private string countrycodeField;

    private string postalcodeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("country-code")]
    public string countrycode
    {
        get
        {
            return this.countrycodeField;
        }
        set
        {
            this.countrycodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("postal-code", DataType = "normalizedString")]
    public string postalcode
    {
        get
        {
            return this.postalcodeField;
        }
        set
        {
            this.postalcodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
public partial class mailingscenarioDestinationUnitedstates
{

    private string zipcodeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("zip-code")]
    public string zipcode
    {
        get
        {
            return this.zipcodeField;
        }
        set
        {
            this.zipcodeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
[System.Xml.Serialization.XmlRootAttribute("price-quotes", Namespace = "http://www.canadapost.ca/ws/ship/rate-v4", IsNullable = false)]
public partial class pricequotes
{

    private pricequotesPricequote[] pricequoteField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("price-quote")]
    public pricequotesPricequote[] pricequote
    {
        get
        {
            return this.pricequoteField;
        }
        set
        {
            this.pricequoteField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
public partial class pricequotesPricequote
{

    private string servicecodeField;

    private LinkType servicelinkField;

    private string servicenameField;

    private pricequotesPricequotePricedetails pricedetailsField;

    private pricequotesPricequoteWeightdetails weightdetailsField;

    private pricequotesPricequoteServicestandard servicestandardField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("service-code", DataType = "normalizedString")]
    public string servicecode
    {
        get
        {
            return this.servicecodeField;
        }
        set
        {
            this.servicecodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("service-link")]
    public LinkType servicelink
    {
        get
        {
            return this.servicelinkField;
        }
        set
        {
            this.servicelinkField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("service-name", DataType = "normalizedString")]
    public string servicename
    {
        get
        {
            return this.servicenameField;
        }
        set
        {
            this.servicenameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("price-details")]
    public pricequotesPricequotePricedetails pricedetails
    {
        get
        {
            return this.pricedetailsField;
        }
        set
        {
            this.pricedetailsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("weight-details")]
    public pricequotesPricequoteWeightdetails weightdetails
    {
        get
        {
            return this.weightdetailsField;
        }
        set
        {
            this.weightdetailsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("service-standard")]
    public pricequotesPricequoteServicestandard servicestandard
    {
        get
        {
            return this.servicestandardField;
        }
        set
        {
            this.servicestandardField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
public partial class pricequotesPricequotePricedetails
{

    private decimal baseField;

    private pricequotesPricequotePricedetailsTaxes taxesField;

    private decimal dueField;

    private pricequotesPricequotePricedetailsOption[] optionsField;

    private pricequotesPricequotePricedetailsAdjustment[] adjustmentsField;

    /// <remarks/>
    public decimal @base
    {
        get
        {
            return this.baseField;
        }
        set
        {
            this.baseField = value;
        }
    }

    /// <remarks/>
    public pricequotesPricequotePricedetailsTaxes taxes
    {
        get
        {
            return this.taxesField;
        }
        set
        {
            this.taxesField = value;
        }
    }

    /// <remarks/>
    public decimal due
    {
        get
        {
            return this.dueField;
        }
        set
        {
            this.dueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("option", IsNullable = false)]
    public pricequotesPricequotePricedetailsOption[] options
    {
        get
        {
            return this.optionsField;
        }
        set
        {
            this.optionsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("adjustment", IsNullable = false)]
    public pricequotesPricequotePricedetailsAdjustment[] adjustments
    {
        get
        {
            return this.adjustmentsField;
        }
        set
        {
            this.adjustmentsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
public partial class pricequotesPricequotePricedetailsTaxes
{

    private TaxType gstField;

    private TaxType pstField;

    private TaxType hstField;

    /// <remarks/>
    public TaxType gst
    {
        get
        {
            return this.gstField;
        }
        set
        {
            this.gstField = value;
        }
    }

    /// <remarks/>
    public TaxType pst
    {
        get
        {
            return this.pstField;
        }
        set
        {
            this.pstField = value;
        }
    }

    /// <remarks/>
    public TaxType hst
    {
        get
        {
            return this.hstField;
        }
        set
        {
            this.hstField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
public partial class pricequotesPricequotePricedetailsOption
{

    private string optioncodeField;

    private string optionnameField;

    private decimal optionpriceField;

    private pricequotesPricequotePricedetailsOptionQualifier qualifierField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("option-code", DataType = "normalizedString")]
    public string optioncode
    {
        get
        {
            return this.optioncodeField;
        }
        set
        {
            this.optioncodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("option-name", DataType = "normalizedString")]
    public string optionname
    {
        get
        {
            return this.optionnameField;
        }
        set
        {
            this.optionnameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("option-price")]
    public decimal optionprice
    {
        get
        {
            return this.optionpriceField;
        }
        set
        {
            this.optionpriceField = value;
        }
    }

    /// <remarks/>
    public pricequotesPricequotePricedetailsOptionQualifier qualifier
    {
        get
        {
            return this.qualifierField;
        }
        set
        {
            this.qualifierField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
public partial class pricequotesPricequotePricedetailsOptionQualifier
{

    private decimal stepsizeField;

    private bool stepsizeFieldSpecified;

    private decimal stepcostField;

    private bool stepcostFieldSpecified;

    private decimal includedamountField;

    private bool includedamountFieldSpecified;

    private decimal maxvalueField;

    private bool maxvalueFieldSpecified;

    private bool includedField;

    private bool includedFieldSpecified;

    private decimal percentField;

    private bool percentFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("step-size")]
    public decimal stepsize
    {
        get
        {
            return this.stepsizeField;
        }
        set
        {
            this.stepsizeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool stepsizeSpecified
    {
        get
        {
            return this.stepsizeFieldSpecified;
        }
        set
        {
            this.stepsizeFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("step-cost")]
    public decimal stepcost
    {
        get
        {
            return this.stepcostField;
        }
        set
        {
            this.stepcostField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool stepcostSpecified
    {
        get
        {
            return this.stepcostFieldSpecified;
        }
        set
        {
            this.stepcostFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("included-amount")]
    public decimal includedamount
    {
        get
        {
            return this.includedamountField;
        }
        set
        {
            this.includedamountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool includedamountSpecified
    {
        get
        {
            return this.includedamountFieldSpecified;
        }
        set
        {
            this.includedamountFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("max-value")]
    public decimal maxvalue
    {
        get
        {
            return this.maxvalueField;
        }
        set
        {
            this.maxvalueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maxvalueSpecified
    {
        get
        {
            return this.maxvalueFieldSpecified;
        }
        set
        {
            this.maxvalueFieldSpecified = value;
        }
    }

    /// <remarks/>
    public bool included
    {
        get
        {
            return this.includedField;
        }
        set
        {
            this.includedField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool includedSpecified
    {
        get
        {
            return this.includedFieldSpecified;
        }
        set
        {
            this.includedFieldSpecified = value;
        }
    }

    /// <remarks/>
    public decimal percent
    {
        get
        {
            return this.percentField;
        }
        set
        {
            this.percentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool percentSpecified
    {
        get
        {
            return this.percentFieldSpecified;
        }
        set
        {
            this.percentFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
public partial class pricequotesPricequotePricedetailsAdjustment
{

    private string adjustmentcodeField;

    private string adjustmentnameField;

    private decimal adjustmentcostField;

    private pricequotesPricequotePricedetailsAdjustmentQualifier qualifierField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("adjustment-code", DataType = "normalizedString")]
    public string adjustmentcode
    {
        get
        {
            return this.adjustmentcodeField;
        }
        set
        {
            this.adjustmentcodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("adjustment-name", DataType = "normalizedString")]
    public string adjustmentname
    {
        get
        {
            return this.adjustmentnameField;
        }
        set
        {
            this.adjustmentnameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("adjustment-cost")]
    public decimal adjustmentcost
    {
        get
        {
            return this.adjustmentcostField;
        }
        set
        {
            this.adjustmentcostField = value;
        }
    }

    /// <remarks/>
    public pricequotesPricequotePricedetailsAdjustmentQualifier qualifier
    {
        get
        {
            return this.qualifierField;
        }
        set
        {
            this.qualifierField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
public partial class pricequotesPricequotePricedetailsAdjustmentQualifier
{

    private decimal percentField;

    /// <remarks/>
    public decimal percent
    {
        get
        {
            return this.percentField;
        }
        set
        {
            this.percentField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
public partial class pricequotesPricequoteWeightdetails
{

    private decimal cubedweightField;

    private bool cubedweightFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("cubed-weight")]
    public decimal cubedweight
    {
        get
        {
            return this.cubedweightField;
        }
        set
        {
            this.cubedweightField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool cubedweightSpecified
    {
        get
        {
            return this.cubedweightFieldSpecified;
        }
        set
        {
            this.cubedweightFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.canadapost.ca/ws/ship/rate-v4")]
public partial class pricequotesPricequoteServicestandard
{

    private bool amdeliveryField;

    private bool guaranteeddeliveryField;

    private string expectedtransittimeField;

    private System.DateTime expecteddeliverydateField;

    private bool expecteddeliverydateFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("am-delivery")]
    public bool amdelivery
    {
        get
        {
            return this.amdeliveryField;
        }
        set
        {
            this.amdeliveryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("guaranteed-delivery")]
    public bool guaranteeddelivery
    {
        get
        {
            return this.guaranteeddeliveryField;
        }
        set
        {
            this.guaranteeddeliveryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("expected-transit-time", DataType = "integer")]
    public string expectedtransittime
    {
        get
        {
            return this.expectedtransittimeField;
        }
        set
        {
            this.expectedtransittimeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("expected-delivery-date", DataType = "date")]
    public System.DateTime expecteddeliverydate
    {
        get
        {
            return this.expecteddeliverydateField;
        }
        set
        {
            this.expecteddeliverydateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool expecteddeliverydateSpecified
    {
        get
        {
            return this.expecteddeliverydateFieldSpecified;
        }
        set
        {
            this.expecteddeliverydateFieldSpecified = value;
        }
    }
}
