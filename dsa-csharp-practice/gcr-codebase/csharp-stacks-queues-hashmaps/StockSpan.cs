using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_stacks_queues_hashmaps
{
    internal class StockSpan
    {

        public static void Main(string[] args)
        {
            //take the size of array to store stock prices
            Console.WriteLine("ENTER SIZE: ");
            int size = Convert.ToInt32(Console.ReadLine());

            //create array to store stocks prices
            int[] stocks = new int[size];

            //loop to take prices of stocks
            for (int i = 0; i < stocks.Length; i++)
            {
                Console.Write("ENTER PRICE: ");
                stocks[i] = Convert.ToInt32(Console.ReadLine());
            }

            //display stocks
            Console.WriteLine("STOCKS: ");
            foreach (int stock in stocks)
            {
                Console.Write(stock + " ");
            }

            //call FindStockSpan method to calculate stock span
            FindStockSpan(stocks);
        }

        //method to calculate stock span
        public static void FindStockSpan(int[] stocks)
        {
            //create stack to store indices of stock prices
            Stack<int> st = new Stack<int>();

            //array to store span values
            int[] span = new int[stocks.Length];

            //span of first day is always 1
            span[0] = 1;

            //push index of first day
            st.Push(0);

            //loop through stocks array
            for (int i = 1; i < stocks.Length; i++)
            {
                //variable to store current day stock price
                int currPrice = stocks[i];

                //remove indices from stack if current price is greater than previous prices
                while (st.Count > 0 && currPrice > stocks[st.Peek()])
                {
                    st.Pop();
                }

                //if stack is empty 
                if (st.Count == 0)
                {
                    //assign span days
                    span[i] = i + 1;
                }
                else
                {
                    //span is difference of indices
                    span[i] = i - st.Peek();
                }

                //push current day index in stack
                st.Push(i);
            }

            //display stock span 
            Console.WriteLine("\nSTOCK SPAN: ");
            foreach (int i in span)
            {
                Console.Write(i + " ");
            }
        }
    }
}
