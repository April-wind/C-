using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRUCache<T> : MonoBehaviour
{//字典(查询 O(1))+链表(淘汰 O(1))
    
    /*链表长度*/
    private int _size;
    /*缓存容量*/
    private int _capacity;
    
    /*链表头节点*/
    private ListNode<T> _listHead;
    /*键 + 缓存数据*/
    private Dictionary<int, ListNode<T>> _dictionary;

    public LRUCache(int capacity)
    {
        _listHead = new ListNode<T>(-1, default(T));
        _listHead.Next = _listHead.Prev = _listHead;
        this._size = 0;
        this._capacity = capacity;
        this._dictionary = new Dictionary<int, ListNode<T>>();
    }

    public T Get(int key)
    {
        //如果字典里已经有该页面
        if (_dictionary.ContainsKey(key))
        {
            ListNode<T> n = _dictionary[key];
            MoveToHead(n);
            return n.Value;
        }
        else
        {
            return default(T);
        }
    }

    public void Set(int key, T value)
    {
        ListNode<T> n;
        if (_dictionary.ContainsKey(key))
        {
            n = _dictionary[key];
            n.Value = value;
            MoveToHead(n);
        }
        else
        {
            n = new ListNode<T>(key, value);
            AttachToHead(n);
            _size ++;
        }

        if (_size > _capacity)
        {
            RemoveLast();
            _size--;
        }
        _dictionary.Add(key, n);
    }

    /// <summary>
    /// 移除链表尾节点
    /// </summary>
    private void RemoveLast()
    {
        ListNode<T> lastNode = _listHead.Prev;
    }

    /// <summary>
    /// 把孤立的目标节点放在链表头部
    /// </summary>
    /// <param name="n"></param>
    private void AttachToHead(ListNode<T> n)
    {
        n.Prev = _listHead;
        n.Next = _listHead.Next;
        _listHead.Next.Prev = n;
        _listHead.Next = n;
    }

    /// <summary>
    /// 将链表中的某个节点放在链表头部
    /// </summary>
    /// <param name="n"></param>
    private void MoveToHead(ListNode<T> n)
    {
        //先删除该节点 ，使其成为孤立节点
        RemoveFromList(n);
        //将孤立的目标节点放在链表头部
        AttachToHead(n);
    }
    
    /// <summary>
    /// 将目标节点从链表删除
    /// </summary>
    /// <param name="n"></param>
    private void RemoveFromList(ListNode<T> n)
    {
        n.Prev.Next = n.Next;
        n.Next.Prev = n.Prev;
    }
}

public class ListNode<T>
{
    /*前向节点*/
    public ListNode<T> Prev;
    /*后向节点*/
    public ListNode<T> Next;
    /*节点值*/
    public T Value;
    /*节点键*/
    public int Key;

    public ListNode(int key, T value)
    {
        this.Value = value;
        this.Key = key;
        this.Prev = null;
        this.Next = null;
    }
}
