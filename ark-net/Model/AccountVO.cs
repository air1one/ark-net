﻿namespace ArkNet.Model
{
    public class AccountVO
    {


        public string address { get; set; }
        public string unconfirmedBalance { get; set; }
        public string balance { get; set; }
        public string publicKey { get; set; }
        public int unconfirmedSignature { get; set; }
        public int secondSignature { get; set; }
        public object secondPublicKey { get; set; }
        public object[] multisignatures { get; set; }
        public object[] u_multisignatures { get; set; }

    }
}