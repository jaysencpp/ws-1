import reactLogo from "./assets/react.svg";
import viteLogo from "/vite.svg";
import "./App.css";
import { Counter } from "./Counter";
import { useEffect, useState } from "react";
import { LintErrors } from "./LintErrors";
import { Views } from "./Views";

// TODO: Change all div-tags in App-component to be <main>-tag
function App() {
   return (
      <div>
         <HelloWorld />
         <LintErrors />
         <Views num={10} />
         <Counter />
      </div>
   );
}
// TODO: Move to new file
export const HelloWorld = () => {
   return <div>Hello World</div>;
};

export default App;
