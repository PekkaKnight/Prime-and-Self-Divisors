using System;
class Number{
    public static bool IsSelfDivisor(int num){
        int number = num;
        while(number > 0){
            int digit = number % 10;
            if(digit == 0 || num % digit != 0){
                return false;
            }
            number = number/10;
        }
        return true;
    }
    public static void ReturnNumSelfDivisors(int num, int size){
        int[] arr = new int[size];
        for(int i = 0; i < size; i++){
            do{
                num++;
            }
            while(!IsSelfDivisor(num));
            arr[i] = num;
        }
        foreach(int item in arr){
            Console.Write(item + " ");
        }
    }
    public static bool IsPrime(int num){
        for(int i = 1; i < num; i++){
            if(i != num && i != 1){
                if(num % i == 0){
                    return false;
                }
            }
        }
        return true;
    }
    public static void ReturnPrimesAfter(int num, int times){
        int[] arr = new int[times];
        for(int i = 0; i < times; i++){
            do{
              num++;
            }
            while(!IsPrime(num));
            arr[i] = num;
        }
        foreach(int item in arr){
            Console.Write(item + " ");
        }
    }
}
