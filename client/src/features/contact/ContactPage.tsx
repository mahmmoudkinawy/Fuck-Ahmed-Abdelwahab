import { Divider, Typography } from "@mui/material";

export default function ContactPage() {
  return (
    <>
      <iframe
        style={{ width: "85vw", height: "100vh", padding: 0, margin: 0 }}
        title="Test"
        src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3435.0663970418727!2d31.00633001460677!3d30.575671000237243!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14f7d6bf14e416e9%3A0xc49ca19e02abe2d2!2sFaculty%20of%20Computers%20and%20Information!5e0!3m2!1sen!2seg!4v1640364023167!5m2!1sen!2seg"
        loading="lazy"
      ></iframe>

      <Divider />

      <Typography variant="h3" style={{ marginBottom: 2, textAlign: "center" }}>
        None - there is no place!
      </Typography>
    </>
  );
}
