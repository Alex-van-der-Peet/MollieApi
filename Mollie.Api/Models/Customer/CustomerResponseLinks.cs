﻿using Mollie.Api.Models.List;
using Mollie.Api.Models.Subscription;
using Mollie.Api.Models.Url;

namespace Mollie.Api.Models.Customer {
    public class CustomerResponseLinks {
        /// <summary>
        /// The API resource URL of the customer itself.
        /// </summary>
        public UrlObjectLink<CustomerResponse> Self { get; set; }

        /// <summary>
        /// The API resource URL of the subscriptions belonging to the Customer, if there are no subscriptions this parameter is omitted.
        /// </summary>
        public UrlObjectLink<ListResponse<SubscriptionResponse>> Subscriptions { get; set; }

        /// <summary>
        /// The URL to the customer retrieval endpoint documentation.
        /// </summary>
        public UrlLink Documentation { get; set; }
    }
}