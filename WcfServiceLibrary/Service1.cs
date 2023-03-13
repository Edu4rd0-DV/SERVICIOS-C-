using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DAL;
using EN;
using BL;

namespace WcfServiceLibrary
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        InventarioBL _bl3 = new InventarioBL();
        public int agregar_inventario(Inventariob pen3)
        {
            return _bl3.agregar_inventario(pen3);
        }
        public int actualizar_inventario(Inventariob pen3)
        {
            return _bl3.actualizar_inventario(pen3);
        }
        public int eliminar_inventario(Inventariob pen3)
        {
            return _bl3.elimina_inventario(pen3);
        }
        public List<Inventariob> mostrar_inventario()
        {
            return _bl3.mostrar_inventario();
        }

        public List<Inventariob> buscar_inventario(Inventariob pen3)
        {
            return _bl3.buscar_inventario(pen3);
        }

        public List<Inventariob> mostrar_inventartio_id(Int64 pen3)
        {
            return _bl3.mostrar_inventario_id(pen3);
        }

        public Inventariob Listar_Productos_carrito(Int64 pen)
        {
            return _bl3.Listar_Productos_carrito(pen);
        }

        public List<Inventariob> mostrar_inventario_mujeres()
        {
            return _bl3.mostrar_inventario_mujeres();
        }

        public List<Inventariob> mostrar_inventario_hombres()
        {
            return _bl3.mostrar_inventario_hombres();
        }

        public List<Inventariob> ventas_top()
        {
            return _bl3.ventas_top();
        }
    
    //---------------------------------------------------------------------------------------
    productoBL _bl4 = new productoBL();
        public int agregar_producto(Producto pen4)
        {
            return _bl4.agregar_producto(pen4);
        }
        public int actualizar_producto(Producto pen4)
        {
            return _bl4.actualizar_producto(pen4);
        }
        public int eliminar_producto(Producto pen4)
        {
            return _bl4.eliminar_producto(pen4);
        }
        public List<Producto> mostrar_producto()
        {
            return _bl4.mostrar_producto();
        }
        public List<Producto>buscar_producto(Producto pen4)
        {
            return _bl4.buscar_producto(pen4);
        }
        //-------------------------------------------tipo------------------------------------------------
        tipoBL _bl5 = new tipoBL();
        public int agregar_tipo(tipo pen5)
        {
            return _bl5.agregar_tipo(pen5);
        }
        public List<tipo> mostrar_tipo()
        {
            return _bl5.mostrar_tipo();
        }
        public  int actualizar_tipo(tipo pen5)
        {
            return _bl5.actualizar_tipo(pen5);
        }
        public int eliminar_tipo(tipo pen5)
        {
            return _bl5.eliminar_tipo( pen5);
        }
        public List<tipo> buscar_tipo(tipo pen5)
        {
            return _bl5.buscar_tipo(pen5);
        }
        //-------------------------------------------------------------------------------------------
        presentacionBL _bl6 = new presentacionBL();
        public int agregar_presentacion(presentacion pen6)
        {
            return _bl6.agregar_presentacion(pen6);
        }
        public List<presentacion> mostrar_presentacion()
        {
            return _bl6.mostrar_presentacion();
        }

        public int actualizar_presentacion(presentacion pen6)
        {
            return _bl6.actualizar_presentacion(pen6);
        }
        public int eliminar_presentacion(presentacion pen6)
        {
            return _bl6.eliminar_presentacion(pen6);
        }

        public List<presentacion>buscar_presentacion(presentacion pen6)
        {
            return _bl6.buscar_presentacion(pen6);
        }
        //---------------------------------------------------------------------
        proveedorBL _bl7 = new proveedorBL();
        public int agregar_proveedor(proveedor pen7)
        {
            return _bl7.agregar_proveedor(pen7);
        }
        public int actualizar_proveedor(proveedor pen7)
        {
            return _bl7.actualizar_proveedor(pen7);
        }
        public int eliminar_proveedor(proveedor pen7)
        {
            return _bl7.eliminar_proveedor(pen7);
        }
        public List<proveedor> mostrar_proveedor()
        {
            return _bl7.mostrar_proveedor();
        }
        public List<proveedor> buscar_proveedor( proveedor pen7)
        {
            return _bl7.buscar_proveedor(pen7);
        }
        //---------------------------------------------------------------------
        UsuarioBL _bl8 = new UsuarioBL();
        public int agregar_usuario(Usuario pen8)
        {
            return _bl8.agregar_usuario(pen8);
        }
        public int eliminar_usuario(Usuario pen8)
        {
            return _bl8.elimina_usuario(pen8);
        }
        public int validar_usuario(Usuario pen8)
        {
            return _bl8.validar_usuario(pen8);
        }

        public List<Usuario>mostrar_usuario_correo(Usuario pen8)
        {
            return _bl8.mostrar_usuario_correo(pen8);
        }

        public List<Usuario>mostrar_usuario_id(Int64 pen8)
        {
            return _bl8.mostrar_usuario_id(pen8);
        }

        public int actualizar_usuario(Usuario pen8)
        {
            return _bl8.actualizar_usuario(pen8);
        }

        //---------------------------------------sexo---------------------
        sexoBL _bl9 = new sexoBL();
        public int agregar_sexo(sexo pen9)
        {
            return _bl9.agregar_sexo(pen9);
        }
        public List<sexo> mostrar_sexo()
        {
            return _bl9.mostrar_sexo();
        }
        //-------------------------- cargo-------------------------------
        cargoBL _bl10 = new cargoBL();
        public int agregar_cargo(cargo pen10)
        {
            return _bl10.agregar_cargo(pen10);
        }

        public List<cargo> mostrar_cargo()
        {
            return _bl10.mostrar_cargo();
        }

        //.-----------------------empleado----------------------------------
        empleadoBL _bl11 = new empleadoBL();
        public int agregar_empleado(Empleado pen11)
        {
            return _bl11.agregar_empleado(pen11);
        }
        public int actualizar_empleado(Empleado pen11)
        {
            return _bl11.actualizar_empelados(pen11);
        }

        public int eliminar_empleado(Empleado pen11)
        {
            return _bl11.eliminar_empleado(pen11);
        }

        public List<Empleado> mostrar_empleado()
        {
            return _bl11.mostrar_empleados();
        }

        public int validar_empleado(Empleado pen11)
        {
            return _bl11.validar_empleado(pen11);
        }

        //---------------------------------------------------------------------------------------

        ventasBL _bl12 = new ventasBL();
        public int agregar_ventas(ventas pen12)
        {
            return _bl12.agregar_venta(pen12);
        }
        public List<ventas> mostrar_ventas()
        {
            return _bl12.mostrar_ventas();
        }

        public List<ventas> buscar_ventas( ventas pen12)
        {
            return _bl12.buscar_venta(pen12);
        }
       
    }
}
