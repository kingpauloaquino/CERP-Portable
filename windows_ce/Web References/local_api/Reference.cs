﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5420
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.CompactFramework.Design.Data, Version 2.0.50727.5420.
// 
namespace windows_ce.local_api {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CERPServiceSoap", Namespace="http://cerp.com/")]
    public partial class CERPService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public CERPService() {
            this.Url = "http://192.168.0.108/cerp-ws/CERPService.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com/DBConTest", RequestNamespace="http://cerp.com/", ResponseNamespace="http://cerp.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool DBConTest() {
            object[] results = this.Invoke("DBConTest", new object[0]);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginDBConTest(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("DBConTest", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndDBConTest(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com/GetDetails", RequestNamespace="http://cerp.com/", ResponseNamespace="http://cerp.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDetails(string barcode, string type) {
            object[] results = this.Invoke("GetDetails", new object[] {
                        barcode,
                        type});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetDetails(string barcode, string type, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetDetails", new object[] {
                        barcode,
                        type}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetDetails(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com/GetStock", RequestNamespace="http://cerp.com/", ResponseNamespace="http://cerp.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetStock(string barcode, string type) {
            object[] results = this.Invoke("GetStock", new object[] {
                        barcode,
                        type});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetStock(string barcode, string type, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetStock", new object[] {
                        barcode,
                        type}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetStock(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com/GetStockItems", RequestNamespace="http://cerp.com/", ResponseNamespace="http://cerp.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetStockItems(string barcode, string type) {
            object[] results = this.Invoke("GetStockItems", new object[] {
                        barcode,
                        type});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetStockItems(string barcode, string type, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetStockItems", new object[] {
                        barcode,
                        type}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetStockItems(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com/AdjustStockItem", RequestNamespace="http://cerp.com/", ResponseNamespace="http://cerp.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AdjustStockItem(int inventory_id, double qty, string remarks) {
            object[] results = this.Invoke("AdjustStockItem", new object[] {
                        inventory_id,
                        qty,
                        remarks});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginAdjustStockItem(int inventory_id, double qty, string remarks, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("AdjustStockItem", new object[] {
                        inventory_id,
                        qty,
                        remarks}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndAdjustStockItem(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com/GetDeliveries", RequestNamespace="http://cerp.com/", ResponseNamespace="http://cerp.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDeliveries() {
            object[] results = this.Invoke("GetDeliveries", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetDeliveries(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetDeliveries", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetDeliveries(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com/GetDeliveryItems", RequestNamespace="http://cerp.com/", ResponseNamespace="http://cerp.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetDeliveryItems(int delivery_id) {
            object[] results = this.Invoke("GetDeliveryItems", new object[] {
                        delivery_id});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetDeliveryItems(int delivery_id, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetDeliveryItems", new object[] {
                        delivery_id}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetDeliveryItems(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com/ReceiveDelivery", RequestNamespace="http://cerp.com/", ResponseNamespace="http://cerp.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ReceiveDelivery(int delivery_id, string invoice, string receipt, string lot_no, string receiving_remarks, string items) {
            object[] results = this.Invoke("ReceiveDelivery", new object[] {
                        delivery_id,
                        invoice,
                        receipt,
                        lot_no,
                        receiving_remarks,
                        items});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginReceiveDelivery(int delivery_id, string invoice, string receipt, string lot_no, string receiving_remarks, string items, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ReceiveDelivery", new object[] {
                        delivery_id,
                        invoice,
                        receipt,
                        lot_no,
                        receiving_remarks,
                        items}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndReceiveDelivery(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com/GetMaterialIssuance", RequestNamespace="http://cerp.com/", ResponseNamespace="http://cerp.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetMaterialIssuance() {
            object[] results = this.Invoke("GetMaterialIssuance", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetMaterialIssuance(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetMaterialIssuance", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetMaterialIssuance(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com/GetMaterialIssuanceItems", RequestNamespace="http://cerp.com/", ResponseNamespace="http://cerp.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetMaterialIssuanceItems(int request_id) {
            object[] results = this.Invoke("GetMaterialIssuanceItems", new object[] {
                        request_id});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetMaterialIssuanceItems(int request_id, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetMaterialIssuanceItems", new object[] {
                        request_id}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndGetMaterialIssuanceItems(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://cerp.com/ReleaseMaterials", RequestNamespace="http://cerp.com/", ResponseNamespace="http://cerp.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string ReleaseMaterials(int device_id, int request_id, string items) {
            object[] results = this.Invoke("ReleaseMaterials", new object[] {
                        device_id,
                        request_id,
                        items});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginReleaseMaterials(int device_id, int request_id, string items, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ReleaseMaterials", new object[] {
                        device_id,
                        request_id,
                        items}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndReleaseMaterials(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
    }
}
