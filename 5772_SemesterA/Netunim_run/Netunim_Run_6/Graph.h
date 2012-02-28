#pragma once
#include <map>
#include <queue>
#include <set>
using namespace std;

//template classes must be in one file. see http://www.cplusplus.com/doc/tutorial/templates/ in the last paragraphs.

template<class T>
class Graph
{
protected:
	map<T, map<T, unsigned>> E; //adjacency matrix
	set<T> V; //vertices
public:
	/*
	All functions that perform something and return a boolean variable 
	- This variable indicates if the execution succeeded or failed.
	for example: try to remove unknown vertex - will fail...
	*/

	//constructor
	Graph();
	//add a vertex
	bool addVertex(const T & vertex);
	//remove a vertex
	bool removeVertex(const T & vertex);
	//add one edge that goes from "from" to "to"
	bool addEdge(const T & from, const T & to);
	//remove one edge
	bool removeEdge(const T & from, const T & to);
	//update the amount of edges
	bool updateEdges(const T & from, const T & to, int add);
	//get the amount of edges
	unsigned getEdges(const T & from, const T & to);
	//return whether there is an edge that goes from "from" to "to"
	bool thereIsEdge(const T & from, const T & to) { return getEdges(from, to) > 0; }
	//return whether there is a path that goes from "from" to "to"
	bool thereIsPath(const T & from, const T & to);
	//Print all pairs of vertices (A, B) having an edge from A to B and an edge from B to A
	void printPairs();
};

template<class T> 
Graph<T>::Graph() {
	V = set<T>();
	E = map<T, map<T, unsigned>>();
}

template<class T> 
bool Graph<T>::addVertex(const T & vertex) {
	return V.insert(vertex).second;
}

template<class T> 
bool Graph<T>::removeVertex(const T & vertex) {
	if (V.erase(vertex) == 0) return false;
	E.erase(vertex);
	for(map<T, map<T, unsigned>>::iterator it = E.begin(); it != E.end(); ++it)
		it->second.erase(vertex);
	return true;
}

template<class T> 
bool Graph<T>::addEdge(const T & from, const T & to) {
	if (V.find(from) == V.end() || V.find(to) == V.end()) return false;
	++(E[from][to]);
	return true;
}

template<class T> 
bool Graph<T>::removeEdge(const T & from, const T & to) {
	if (E[from][to] > 0) {
		--(E[from][to]);
		return true;
	} else {
		return false;
	}
}

template<class T> 
bool Graph<T>::updateEdges(const T & from, const T & to, int add) {
	if (add == 0) return false;
	if (E[from][to] + add < 0)
		return false;
	E[from][to] += add;
	return true;
}

template<class T> 
unsigned Graph<T>::getEdges(const T & from, const T & to) {
	return E[from][to];
}

template<class T> 
bool Graph<T>::thereIsPath(const T & from, const T & to) {
	if (V.find(from) == V.end() || V.find(to) == V.end()) return false;
	if (thereIsEdge(from, to)) return true;
	set<T> visited = set<T>();
	queue<T> toVisit = queue<T>();
	visited.insert(from);
	toVisit.push(from);
	do {
		for(map<T, unsigned>::iterator it = E[toVisit.front()].begin(); it != E[toVisit.front()].end(); ++it) {
			if (it->second == 0 || visited.find(it->first) != visited.end()) continue;
			if (E[it->first][to] > 0) return true;
			visited.insert(it->first);
			toVisit.push(it->first);
		}
		toVisit.pop();
	} while (!toVisit.empty());
	return false;
}
template<class T> 
void Graph<T>::printPairs() {
	cout << "pairs:" << endl;
	for(map<T, map<T, unsigned>>::iterator it = E.begin(); it != E.end(); ++it)
		for(map<T, unsigned>::iterator Rit = it->second.begin(); Rit != it->second.end(); ++Rit)
			if (!(it->first < Rit->first) && thereIsEdge(it->first, Rit->first) && thereIsEdge(Rit->first, it->first))
				cout << '(' << it->first << ", " << Rit->first << ')' << endl;
}