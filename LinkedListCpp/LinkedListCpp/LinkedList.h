#pragma once
#include "List.h"
#include "Node.h"

class LinkedList :
	public List
{

private:
	Node * first;
	Node * last;
	int numItens;

public:
	LinkedList();
	~LinkedList();

	Node * getFirst();
	Node * getLast();
	int getNumItens();

	void setFirst(Node & obj);
	void setLast(Node & obj);
	void setNumItens(int num);

	bool isEmpty();


};

