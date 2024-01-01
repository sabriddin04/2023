 class Circle:Shape
{
    protected double radius=1.0;
    public Circle()
    {
        
    }
    public Circle(double radius)
    {
        this.radius=radius;
    }

    public Circle(double radius,string color,bool filled):base(color,filled)
    {
        this.radius=radius;
    }

    public double GetRadius(){
        return radius;
    }
    public void SetRadius(double radius){
        this.radius=radius;
    }

    public override double GetArea()
    {
        return 3.14*radius*radius;
    }
    public override double GetPerimetr()
    {
        return 2*3.14*radius;
    }

    public override string ToString()
    {
        return base.ToString()+$",radius={radius}";
    }




}