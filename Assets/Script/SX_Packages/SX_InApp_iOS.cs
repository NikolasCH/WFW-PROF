////////////////////////////////////////////////////////////////////////////////
//  
// @module IOS Native Plugin for Unity3D 
// @author Osipov Stanislav (Stan's Assets) 
// @support stans.assets@gmail.com 
//
////////////////////////////////////////////////////////////////////////////////

using System;
using UnityEngine;
using SA.iOS.StoreKit;
using SA.iOS.Examples;


    public class SX_InApp_iOS : MonoBehaviour 
    {

        private static SX_BillingClient_iOS s_paymentManager;


        private void Start()
        {

#if UNITY_ANDROID
            GetComponent<SX_InApp_iOS>().enabled = false;
#endif

        if (s_paymentManager == null)
            {
                s_paymentManager = new SX_BillingClient_iOS();
            }


            s_paymentManager.init();
        }


        public void Purchase(string ProductId)
        {

            if (ProductId == "page_1")
                ProductId = "page2_1";
            if (ProductId == "page_2")
                ProductId = "page2_2";
            if (ProductId == "page_3")
                ProductId = "page2_3";
            if (ProductId == "page_4") 
                ProductId = "page2_4";
            if (ProductId == "page_5")
                ProductId = "page2_5";
            if (ProductId == "page_6")
                ProductId = "page2_6";
            if (ProductId == "page_7")
                ProductId = "page2_7";

        ISN_SKPaymentQueue.AddPayment(ProductId);
        }

    }
