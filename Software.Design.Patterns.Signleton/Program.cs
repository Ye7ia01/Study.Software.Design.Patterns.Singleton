using Software.Design.Patterns.Signleton;

var loadBalancer1 = SingletonLoadBalancer.GetInstance();
var loadBalancer2 = SingletonLoadBalancer.GetInstance();
var loadBalancer3 = SingletonLoadBalancer.GetInstance();

Console.WriteLine(loadBalancer1 == loadBalancer2);
Console.WriteLine(loadBalancer2 == loadBalancer3);
Console.WriteLine(loadBalancer1 == loadBalancer3);

if (loadBalancer1 == loadBalancer2 && loadBalancer1 == loadBalancer3 && loadBalancer2 == loadBalancer3)
{
    Console.WriteLine("The same instance of the load balancer was returned");
}
else
{
    Console.WriteLine("Different instances of the load balancer were returned");
}
Console.WriteLine();

Console.WriteLine("Hello, World!");