class Square:Rectangle
{
     public Square()
     {
        
     }


     public Square(double side)
     {
        
     }

     public Square(double side, string color,bool filled):base(side,side,color,filled)
     {
        
     }


    public  double GetSide(){
        return  GetWidth();
    }

    public void SetSide(double side){

         SetWidth(side);
    }
     public void  SetWidth(double side){
        SetWidth(side);
     }
     public void  SetLength(double side){
        SetWidth(side);
     }

    public override string ToString()
    {
        return base.ToString();
    }

}