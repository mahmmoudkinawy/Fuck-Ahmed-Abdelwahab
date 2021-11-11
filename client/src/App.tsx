import { useEffect, useState } from "react";

function App() {
  const [products, setProducts] = useState([
    {
      name: "product1",
      price: 100.0,
    },
    {
      name: "product2",
      price: 200.0,
    },
  ]);

  useEffect(() => {
    fetch("http://localhost:5000/api/products")
      .then((response) => response.json())
      .then((data) => setProducts(data));
  }, []);

  function addProduct() {
    setProducts((preState) => [
      ...preState,
      {
        name: "product" + (preState.length + 1),
        price: preState.length * 100 + 100,
      },
    ]);
  }

  return (
    <div>
      <h1>Julia</h1>
      <ul>
        {products.map((item, index) => (
          <li key={index}>
            {item.name} - {item.price}
          </li>
        ))}
      </ul>
      <button onClick={addProduct}>Add Product</button>
    </div>
  );
}

export default App;
