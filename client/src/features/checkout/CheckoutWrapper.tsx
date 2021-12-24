import { Elements } from "@stripe/react-stripe-js";
import { loadStripe } from "@stripe/stripe-js";
import CheckoutPage from "./CheckoutPage";

const stripePromise = loadStripe(
  "pk_test_51J42sgJpPIQTetfD2C22kl7nDlhW5RyCVLeUfB1r2j5VC7yhzOCLCgwGYVBl6MW3ebLo0EyoNQPVmHXB9NWDaesH00ExEUEwEg"
);

export default function CheckoutWrapper() {
  return (
    <Elements stripe={stripePromise}>
      <CheckoutPage />
    </Elements>
  );
}
