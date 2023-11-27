using IteratorAssignment.Menu;
using IteratorAssignment.Waiters;

Waiter waiter = new Waiter(new PancakeMenu(), new DinerMenu());
waiter.printMenu();