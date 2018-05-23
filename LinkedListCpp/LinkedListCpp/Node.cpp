#include "stdafx.h"
#include "Node.h"

Node::Node()
{
}

Node::Node(Node & obj1, Node & obj2)
{
}

Node::~Node()
{
}

Node* Node::getProx()
{
	return this->prox;
}

Node* Node::getAnt()
{
	return this->ant;
}

void Node::setProx(Node & obj)
{
	prox = &obj;
}

void Node::setAnt(Node & obj)
{
	ant = &obj;
}

