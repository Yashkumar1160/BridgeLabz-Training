using System;
using System;
public class BinarySearch {
    public static void Main(string[]args){
        //Read the size of array
        int n=Convert.ToInt32(Console.ReadLine());
        int[]nums=new int[n];

        //Read sorted array elements
        for(int i=0;i<n;i++){
            nums[i]=Convert.ToInt32(Console.ReadLine());
        }

        //Read element to search
        int target=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(BinarySearching(nums,target));
    }    

    //Method to perform binary search 
    // returns index if found else -1
    public static int BinarySearching(int[]nums,int target) {
        int start=0;
        int end=nums.Length-1;

        //Continue to search until valid range
        while(start<=end){
            int mid=start+(end-start)/2;

            //id element found
            if(nums[mid]==target){
                return mid;
            }
            //if target is smaller then search left half
            else if(target<nums[mid]){
                end=mid-1;
            }
            //if target is greater search right half
            else{
                start=mid+1;
            }
        }
        //if element not found
        return -1;
        
    }
}
