﻿// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

int age = 32;

Console.WriteLine("Your age " + age);


// StackCollectionImp stackDS = new StackCollectionImp();
// stackDS.Push(5);
// stackDS.Push(2);
// stackDS.Push(51);
// stackDS.Push(76);
// stackDS.Display();
// stackDS.Pop();
// stackDS.Display();
// stackDS.Peek();
// stackDS.Contain(5);
// stackDS.ClearStack();
// stackDS.Display();

// QueueDS queueDS = new QueueDS(5);
//QueueCollectionImp queueDS = new QueueCollectionImp();
// queueDS.Enqueue(1);
// queueDS.Enqueue(2);
// queueDS.Enqueue(3);
// queueDS.Enqueue(4);
// queueDS.Enqueue(5);
// queueDS.Enqueue(6);
// queueDS.Display();
// queueDS.Peek();
// queueDS.Dequeue();
// queueDS.Dequeue();
// queueDS.Dequeue();
// queueDS.Dequeue();
// queueDS.Dequeue();
// queueDS.Dequeue();
// queueDS.Display();


SingleLinkedList<int> singleLinkedList = new SingleLinkedList<int>();
singleLinkedList.Display();
singleLinkedList.AddEnd(1);
singleLinkedList.AddEnd(2);
singleLinkedList.AddEnd(3);
singleLinkedList.AddEnd(4);
singleLinkedList.AddStart(5);
singleLinkedList.Display();