#pragma once
class Node
{
private:
	Node* prox;
	Node* ant;


public:
	Node();
	Node(Node & obj1, Node & obj2);
	~Node();

	Node* getProx();
	Node* getAnt();
	void setProx(Node &obj);
	void setAnt(Node &obj);

};

