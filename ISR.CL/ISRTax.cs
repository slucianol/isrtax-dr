namespace ISR.CL {
    public static class ISRTax {
        public static decimal Calculate(decimal amount, bool monthly) {
            if (amount <= 0) {
                return -1;
            }
            if (monthly) {
                amount = amount * 12;
            }
            if (amount >= 768000) {
                return (0.25M * (amount - 316000)) / 12;
            } else if (amount >= 565000) {
                return (0.2M * (amount - 316000)) / 12;
            } else if (amount >= 316000) {
                return (0.15M * (amount - 316000)) / 12;
            }
            return 0M;
        }
    }
}
