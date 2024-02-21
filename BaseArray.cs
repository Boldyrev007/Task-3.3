using System;
namespace fpgiuh
{
	public abstract class BaseArray : IBaseArray
	{

		public void Create(bool choice)
		{
			if (choice)
			{
                fill_RandomArray();
            }
			else
			{
                fillArray_by_User();
            }
		}

		protected abstract void fill_RandomArray();

		protected abstract void fillArray_by_User();

		public abstract void Print();

		public abstract decimal Average_Value();
    }
}

