﻿using System;

namespace Mollie.Api.Models.Subscription {
    public class SubscriptionUpdateRequest {
        /// <summary>
        /// The constant amount in EURO that you want to charge with each subscription payment, e.g. 100.00 if you would want
        /// to charge € 100,00.
        /// </summary>
        public Amount Amount { get; set; }

        /// <summary>
        /// Optional – Total number of charges for the subscription to complete. Leave empty for an on-going subscription.
        /// </summary>
        public int? Times { get; set; }

        /// <summary>
        /// Optional – The start date of the subscription in yyyy-mm-dd format. This is the first day on which your customer
        /// will be charged. When
        /// this parameter is not provided, the current date will be used instead.
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// A description unique per customer. This will be included in the payment description along with the charge date in
        /// Y-m-d format.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Optional – Use this parameter to set a webhook URL for all subscription payments.
        /// </summary>
        public string WebhookUrl { get; set; }
    }
}