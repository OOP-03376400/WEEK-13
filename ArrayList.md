##ArrayList Properties
<table class="table table-bordered">
<tbody><tr>
<th style="width:25%;">Property</th>
<th>Description</th>
</tr>
<tr>
<td>Capacity</td>
<td>Gets or sets the number of elements that the ArrayList can contain.</td>
</tr>
<tr>
<td>Count</td>
<td>Gets the number of elements actually contained in the ArrayList.</td>
</tr>
<tr>
<td>IsFixedSize</td>
<td>Gets a value indicating whether the ArrayList has a fixed size.</td>
</tr>
<tr>
<td>IsReadOnly</td>
<td>Gets a value indicating whether the ArrayList is read-only.</td>
</tr>
<tr>
<td>Item</td>
<td>Gets or sets the element at the specified index.</td>
</tr>
</tbody></table>
##ArrayList Methods

<table class="table table-bordered">
<tbody><tr>
<th style="width:5%;">Sr.No.</th>
<th>Methods</th>
</tr>
<tr>
<td>1</td>
<td><b>public virtual int Add(object value);</b>
<p>Adds an object to the end of the ArrayList.</p></td>
</tr>
<tr>
<td>2</td>
<td><b>public virtual void AddRange(ICollection c);</b>
<p>Adds the elements of an ICollection to the end of the ArrayList.</p>
</td>
</tr>
<tr>
<td>3</td>
<td><b>public virtual void Clear();</b>
<p>Removes all elements from the ArrayList.</p></td>
</tr>
<tr>
<td>4</td>
<td><b>public virtual bool Contains(object item);</b>
<p>Determines whether an element is in the ArrayList.</p>
</td>
</tr>
<tr>
<td>5</td>
<td><b>public virtual ArrayList GetRange(int index, int count);</b>
<p>Returns an ArrayList which represents a subset of the elements in the source ArrayList.</p>
</td>
</tr>
<tr>
<td>6</td>
<td><b>public virtual int IndexOf(object);</b>
<p>Returns the zero-based index of the first occurrence of a value in the ArrayList or in a portion of it.</p></td>
</tr>
<tr>
<td>7</td>
<td><b>public virtual void Insert(int index, object value);</b>
<p>Inserts an element into the ArrayList at the specified index.</p>
</td>
</tr>
<tr>
<td>8</td>
<td><b>public virtual void InsertRange(int index, ICollection c);</b>
<p>Inserts the elements of a collection into the ArrayList at the specified index.</p>
</td>
</tr>
<tr>
<td>9</td>
<td><b>public virtual void Remove(object obj);</b>
<p>Removes the first occurrence of a specific object from the ArrayList.</p>
</td>
</tr>
<tr>
<td>10</td>
<td><b>public virtual void RemoveAt(int index);</b>
<p>Removes the element at the specified index of the ArrayList.</p>
</td>
</tr>
<tr>
<td>11</td>
<td><b>public virtual void RemoveRange(int index, int count);</b>
<p>Removes a range of elements from the ArrayList.</p>
</td>
</tr>
<tr>
<td>12</td>
<td><b>public virtual void Reverse();</b>
<p>Reverses the order of the elements in the ArrayList.</p></td>
</tr>
<tr>
<td>13</td>
<td><b>public virtual void SetRange(int index, ICollection c);</b>
<p>Copies the elements of a collection over a range of elements in the ArrayList.</p>
</td>
</tr>
<tr>
<td>14</td>
<td><b>public virtual void Sort();</b>
<p>Sorts the elements in the ArrayList.</p></td>
</tr>
<tr>
<td>15</td>
<td><b>public virtual void TrimToSize();</b>
<p>Sets the capacity to the actual number of elements in the ArrayList.</p></td>
</tr>
</tbody></table>
