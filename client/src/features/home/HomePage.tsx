import { Box, Typography } from "@mui/material";
import Slider from "react-slick";

export default function HomePage() {
  const settings = {
    dots: true,
    infinite: true,
    speed: 500,
    slidesToShow: 1,
    slidesToScroll: 1,
  };
  return (
    <>
      <Slider {...settings}>
        <div>
          <img
            src="https://images.unsplash.com/photo-1540221652346-e5dd6b50f3e7?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=869&q=80"
            alt=""
            style={{ display: "block", width: "100%", maxHeight: 600 }}
          />
        </div>
        <div>
          <img
            src="https://images.unsplash.com/photo-1445205170230-053b83016050?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=871&q=80"
            alt=""
            style={{ display: "block", width: "100%", maxHeight: 600 }}
          />
        </div>
        <div>
          <img
            src="https://images.unsplash.com/photo-1612423284934-2850a4ea6b0f?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80"
            alt=""
            style={{ display: "block", width: "100%", maxHeight: 600 }}
          />
        </div>
      </Slider>
      <Box display="flex" justifyContent="center" sx={{ p: 4 }}>
        <Typography>Welcome to the shop!</Typography>
      </Box>
    </>
  );
}
