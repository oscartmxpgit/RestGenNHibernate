
using System;
// Definición clase CocineroEN
namespace RestGenNHibernate.EN.Rest
{
public partial class CocineroEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo rol
 */
private System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.RolEN> rol;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.RolEN> Rol {
        get { return rol; } set { rol = value;  }
}





public CocineroEN()
{
        rol = new System.Collections.Generic.List<RestGenNHibernate.EN.Rest.RolEN>();
}



public CocineroEN(int id, System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.RolEN> rol
                  )
{
        this.init (Id, rol);
}


public CocineroEN(CocineroEN cocinero)
{
        this.init (Id, cocinero.Rol);
}

private void init (int id
                   , System.Collections.Generic.IList<RestGenNHibernate.EN.Rest.RolEN> rol)
{
        this.Id = id;


        this.Rol = rol;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CocineroEN t = obj as CocineroEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
