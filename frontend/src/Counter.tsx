import { useState } from "react";

export const Counter = () => {
   //TODO: Rename symbol "counter" to be "count" intead
   const [counter, setCount] = useState<number>(0);
   const notThisCount = 42;

   console.log(counter);
   return (
      <div>
         <div>{counter}</div>
         {/* TODO: Extract the onClick function to its own constant */}
         <button
            onClick={() => {
               setCount((prev) => prev++);
            }}
         >
            Increment
         </button>
         <div>{counter}</div>
         {/* TODO: Comment out this whole div block */}
         <div>
            <div>
               <p>{notThisCount}</p>
            </div>
         </div>
      </div>
   );
};
