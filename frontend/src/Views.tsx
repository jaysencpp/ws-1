//TODO: Change all occurences of the word 'Lorem' to 'Merol'
//TODO: Change the first two <p>-tags to be <div>-tags
type ViewsProps = {
   num: number;
};
export const Views = (props: ViewsProps) => {
   //TODO: Extract to function
   const calc = props.num > 10 ? "big" : "small";
   return (
      <div>
         <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Laudantium
            ratione animi esse. Nesciunt libero laudantium rerum fugit, corporis
            commodi velit fugiat facere, nobis neque accusamus blanditiis. Minus
            voluptate corporis iusto.
         </p>
         <p>
            Lorem ipsum, dolor sit amet consectetur adipisicing elit. Sequi,
            consectetur. Cumque, amet provident? Eum, laboriosam. Similique
            distinctio impedit totam consequuntur tempore loremmagnam illo
            cumque accusamus delectus veritatis magni, aut molestias.
         </p>
         <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Commodi
            porro officia dolore modi itaque minus natus odit et aspernatur,
            sed, aut cumque mollitia pariatur tempore, quidem repellendus
            architecto laborum veritatis!
         </p>
         {calc}
      </div>
   );
};
