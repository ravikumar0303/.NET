namespace TeamBuilding;
public class Leader{
    public static int count;
    private static  Leader _ref;
    private Leader(){
        count++;

    }

    public static Leader  GetLeader(){
        if(_ref == null){
           _ref=new Leader();
        }
        return _ref;
    }

}