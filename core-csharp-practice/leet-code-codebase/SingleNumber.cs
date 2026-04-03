using System;
class SingleNumber{
	static void Main(string[]args){
		//take size of array
		int n=Convert.ToInt32(Console.ReadLine());
		//define integer array nums
		int[]nums=new int[n];
		
		//take input elements and store it in nums array
		for(int i=0;i<n;i++){
			nums[i]=Convert.ToInt32(Console.ReadLine());
		}
		//find single number
		for(int i=0;i<n;i++){
			//count occurrence of each element
			int count=0;
			for(int j=0;j<n;j++){
				if(nums[i]==nums[j]){
					count++;
				}
			}
			if(count==1){
				Console.WriteLine(nums[i]);
				break;
			}
		}
		
	}
}