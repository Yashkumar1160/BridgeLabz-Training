using System;
class SmallerNumbers{
	static void Main(string[]args){
		//take array size
		int n=Convert.ToInt32(Console.ReadLine());
		//define nums and result array 
		int[]nums=new int[n];
		int[]result=new int[n];
		
		//take input numbers and store in nums array
		for(int i=0;i<n;i++){
			nums[i]=Convert.ToInt32(Console.ReadLine());
		}
		//count smaller numbers
		for(int i=0;i<n;i++){
			int count=0;
			for(int j=0;j<n;j++){
				if(i!=j && nums[j]<nums[i]){
					count++;
				}
			}
			result[i]=count;
		}
		//display elements of nums array
		for(int i=0;i<n;i++){
			Console.Write(result[i]+" ");
		}
	}
}