﻿/***********************************************
 * CONFIDENTIAL AND PROPRIETARY 
 * 
 * The source code and other information contained herein is the confidential and exclusive property of
 * ZIH Corp. and is subject to the terms and conditions in your end user license agreement.
 * This source code, and any other information contained herein, shall not be copied, reproduced, published, 
 * displayed or distributed, in whole or in part, in any medium, by any means, for any purpose except as
 * expressly permitted under such license agreement.
 * 
 * Copyright ZIH Corp. 2018
 * 
 * ALL RIGHTS RESERVED
 ***********************************************/

namespace Zebra.PrintStation.Util {

    public class PrinterInfo {

        public PrinterInfo() { }

        public PrinterInfo(string friendlyName, string address) {
            Address = address;
            FriendlyName = friendlyName;
        }

        public string Address {
            get; set;
        }

        public string FriendlyName {
            get; set;
        }
    }
}
