import React from "react";
import ReactDOM from "react-dom/client";
import App from "./App.tsx";
import "./index.css";
//TODO: Open terminal and run npm run format
//TODO: Open global search panel and find the file that contains "1a": "foo"
//TODO: Search for file `App.tsx` and open it (Ctrl + P)
ReactDOM.createRoot(document.getElementById("root")!).render(
   <React.StrictMode>
      <App />
   </React.StrictMode>,
);
