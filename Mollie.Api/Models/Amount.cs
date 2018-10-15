namespace Mollie.Api.Models {
    public class Amount {
        /// <summary>
        /// An ISO 4217 currency code. The currencies supported depend on the payment methods that are enabled on your account.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// The value of the payment, e.g. 100.00 for a €100.00 payment.
        /// </summary>
        public string Value { get; set; }

        public Amount(string currency, string value) {
            this.Currency = currency;
            this.Value = value;
        }

        public Amount() { }

        public override string ToString() {
            return $"{this.Value} {this.Currency}";
        }
    }
}