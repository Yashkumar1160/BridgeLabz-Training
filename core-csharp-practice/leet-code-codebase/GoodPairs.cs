using System;
class GoodPairs{
	public static void Main(string[]args){
		Console.WriteLine("Enter size:");
		int n=Convert.ToInt32(Console.ReadLine());
		int[]nums=new int[n];
		
		Console.WriteLine("Enter elements");
		for(int i=0;i<n;i++){
			nums[i]=Convert.ToInt32(Console.ReadLine());
		}
		int count=0;
		for(int i=0;i<n;i++){
			for(int j=i+1;j<n;j++){
				if(nums[i]==nums[j]){
					count++;
				}
				
			}
		}
		Console.WriteLine("Good Pairs: "+count);
	}
}