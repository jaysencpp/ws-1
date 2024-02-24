import { useEffect, useState } from "react";
//TODO: Open the terminal and run `npm run lint`
const transform = (s: string) => {
   s = s + "bar";
   return s;
};
export const LintErrors = () => {
   let errors = { foo: "foo" };
   const [show, setShow] = useState(false);
   if (show) {
      useMyHook();
   }

   useEffect(() => {
      if (!show) {
         console.log("Not showing");
      }
   }, []);

   return (
      <div>
         <button onClick={() => setShow(!show)}>Toggle</button>
         <div>
            <a href="www.google.com" target="_blank">
               A link
            </a>
         </div>
         <div>{transform(errors.foo)}</div>
      </div>
   );
};

const useMyHook = () => {
   const [state, setState] = useState();

   return [state, setState];
};
