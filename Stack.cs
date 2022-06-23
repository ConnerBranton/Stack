
class Stack
{
    LinkedList list = new LinkedList();

    private Node _head;         //ref to the top of the stack
    private int _length = 0;

    public void Push(object data)
    {
        //add item to the top of the stack

        if (_head == null)
        {
            list.Add(data);
        }
        else
        {
            list.InsertFront(data);
        }//end if

        _length += 1;      //increase length
    }

    public object Pop()
    {
        //remove the item from top of the stack

        _head.Data = null;       //clear head
        _head = _head.Next;      //set next to equal head

        _length -= 1;            //subtract one from length

        return list;             //return list        
    }

    public object Peek()
    {
        //shows the data on top of the stack without removing it
        return _head.Data;
    }

    public void Clear()
    {
        //removes all items from the stack

        while (_head != null)       //while head is not null
        {
            _head.Data = null;      //head data is null
            _head = _head.Next;     //set new head as old head's next
            _length -= 1;           //subtract one from length
        }
    }
}
