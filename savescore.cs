public void save(string name, int score){
        NCMBObject obj = new NCMBObject ("Score");
        obj.Add ("name", name);
        obj.Add ("score", score);
        obj.SaveAsync ((NCMBException e) => {
            if (e != null){

            }else{

            }
        });
    }
