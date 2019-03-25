﻿using Binance.Client.Websocket.Validations;

namespace Binance.Client.Websocket.Requests
{
    public class InstrumentSubscribeRequest: SubscribeRequestBase
    {
        /// <summary>
        /// Subscribe to instrument updates including turnover and bid/ask from all pairs
        /// </summary>
        public InstrumentSubscribeRequest()
        {
            Symbol = string.Empty;
        }

        /// <summary>
        /// Subscribe to instrument updates including turnover and bid/ask from selected pair ('XBTUSD', etc)
        /// </summary>
        public InstrumentSubscribeRequest(string pair)
        {
            BnbValidations.ValidateInput(pair, nameof(pair));

            Symbol = pair;
        }

        public override string Topic => "instrument";
        public override string Symbol { get; }     
    }
}