﻿using LinksLists;
Console.WriteLine("Hello, Welcome to LinkList Programe...!");
LinkList list = new LinkList();
list.Add(56);
//list.Add(30);
list.Add(70);
list.InsertAtAnyPosition(2, 30);
list.Display();
Console.WriteLine("************************************");
/*list.RemoveFirstNode();
list.Display();
Console.WriteLine("************************************");
list.RemoveLastNode();
list.Display();*/
Console.WriteLine("************************************");
list.Search(30);
list.Display();
