function Fibonacci(num){
    if(num==1 || num==2) return 1
    return Fibonacci(num-1)+Fibonacci(num-2)
}

console.log(Fibonacci(10)) 