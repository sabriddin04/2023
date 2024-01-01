class Rectangle:Shape
{
   protected double width=1.0;
   protected double length=1.0;

   public Rectangle()
   {
    
   }

   public Rectangle(double width,double length )
   {
      this.width=width;
      this.length=length;
   }
    public Rectangle(double width,double length,string color,bool filled ):base(color,filled)
   {
      this.width=width;
      this.length=length;
   }

     public virtual double GetWidth(){
        return width;
    }
    public virtual void SetWidth(double width){
        this.width=width;
    }

     public double GetLength(){
        return length;
    }
    public virtual void SetLength(double length){
        this.length=length;
    }

    public override double GetArea()
    {
        return width*length;
    }

    public override double GetPerimetr()
    {
       return 2*(width+length);
    }


    public override string ToString()
    {
        return $"REctangle"+base.ToString()+$"width={width},length={length}.";
    }






}