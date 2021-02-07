![Image](https://github.com/RobinKim-SWEngineer/Images-for-document/blob/master/rsz_successfulprogrammer.jpg)

# Delegate and Interface in C#

## What are they, delegate and interface ?

Delegate and Interface give our applications the feature, so called **future proof** by letting us allow `extend the program without having to change` the original code. 

1. Delegate defines the signature, to which delegate method(s) should conform. Any method that has same signature as that of delegate can be the delegate method.

2. Interface defines members, to which either class or struct should conform. Any class  or struct that has same members as that of interface can be instantiated as interface object.

The class or struct that implements delegate or interface **doesn`t know how** they do things, it **only knows what** they should do or have. This loosely-coupled way of design gives the program to flexibly extend in the future.  

## So how are they used in the code example ?

There`re two seperate examples, which of the each implements same behavior, one through delegate and another through interface. 

There is a Bank class, which needs three objects who are able to transfer, save and invest. The bank class actually has no knowledge about who and how they to that, it only knows those objects will have these 3 abilities.

- In example
  - Delegate : Bank class needs 3 delegate instances to be instantiated. Those 3 delegate instances should be objects of methods that have same signature as that of delegate definition. One of them is
    `public delegate double InvestmentDelegate(double money);`
  
    When instantiating the bank class, three methods are hooked as delegate instances so Bank class can implement them.
    `Bank happyBank = new Bank(HappyTransactionCorporation.TransactMoney, HappySaveCorporation.Save, HappyInvestCorporation.Invest);`
    
  - Interface : Bank class needs 3 interface instances to be instantiated. Those 3 interface instances should be objects of class or struct that have same members as that of interface. One of them is
    `public interface IInvestable 
    { 
        double Invest(double money);
    }`
  
    When instantiating the bank class, three instances are instantiated and passed so Bank class can implement them.
    `Bank happyBank = new Bank(new HappyTransactionCorporation(), new HappySaveCorporation(), new HappyInvestCorporation());`

## And where is the extensibility ?
In our example, there used to be only one transaction funcionality provider, which is HappyTransactionCorporation. And now the rival company appeared whose name is GloomyTransactionCorporation. So how do we switch to the new provider ?

Simply like the following, without changing Bank class !
- In the delegate exmaple : 
`Bank happyBank = new Bank(GloomyTransactionCorporation.Transact, HappySaveCorporation.Save, HappyInvestCorporation.Invest);`

- In the Interface example :
`Bank happyBank = new Bank(new GloomyTransactCorporation(), new HappySaveCorporation(), new HappyInvestCorporation());`

We just pass new delegate or interface instance to tha bank class, and that instance`s method or members will be called by bank class correspondingly.



