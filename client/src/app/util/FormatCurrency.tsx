import NumberFormat from "react-number-format";

interface Props {
  amount: number;
}

export default function FormatCurrency({ amount }: Props) {
  return (
    <NumberFormat
      value={amount}
      displayType={"text"}
      thousandSeparator={true}
      prefix={"$"}
    />
  );
}
