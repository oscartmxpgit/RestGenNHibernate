
using System;
using RestGenNHibernate.EN.Rest;

namespace RestGenNHibernate.CAD.Rest
{
public partial interface ICamareroCAD
{
CamareroEN ReadOIDDefault (int id
                           );

void ModifyDefault (CamareroEN camarero);

System.Collections.Generic.IList<CamareroEN> ReadAllDefault (int first, int size);



int Nuevo (CamareroEN camarero);

void Modificar (CamareroEN camarero);


void Eliminar (int id
               );
}
}
