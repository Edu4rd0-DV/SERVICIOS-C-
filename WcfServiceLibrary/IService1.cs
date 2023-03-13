using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DAL;
using BL;
using EN;

namespace WcfServiceLibrary
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int agregar_producto(Producto pen4);
        [OperationContract]
        int actualizar_producto(Producto pen4);
        [OperationContract]
        int eliminar_producto(Producto pen4);
        [OperationContract]
        List<Producto> mostrar_producto();
        [OperationContract]
        List<Producto> buscar_producto(Producto pen4);
        //_------------------------------------------------------------
        [OperationContract]
        int agregar_inventario(Inventariob pen3);
        [OperationContract]
        int actualizar_inventario(Inventariob pen3);
        [OperationContract]
        int eliminar_inventario(Inventariob pen3);
        [OperationContract]
        List<Inventariob> mostrar_inventario();
        [OperationContract]
        List<Inventariob> buscar_inventario(Inventariob pen3);

        [OperationContract]
        List<Inventariob> mostrar_inventartio_id(Int64 pen3);
        [OperationContract]
        Inventariob Listar_Productos_carrito(Int64 pen3);
        [OperationContract]
        List<Inventariob> mostrar_inventario_mujeres();
        [OperationContract]
        List<Inventariob> mostrar_inventario_hombres();
        [OperationContract]
        List<Inventariob> ventas_top();
        //-----------------------------tipo-------------------------------------
        [OperationContract]
        int agregar_tipo(tipo pen4);
        [OperationContract]
        List<tipo> mostrar_tipo();
        [OperationContract]
        int actualizar_tipo(tipo pen4);
        [OperationContract]
        int eliminar_tipo(tipo pen4);
        [OperationContract]
        List<tipo> buscar_tipo(tipo pen4);
        //.................--------------------------------------------------
        [OperationContract]
        int agregar_presentacion(presentacion pen5);
        [OperationContract]
        List<presentacion> mostrar_presentacion();
        [OperationContract]
        int actualizar_presentacion(presentacion pen5);
        [OperationContract]
        int eliminar_presentacion(presentacion pen5);
        [OperationContract]
        List<presentacion> buscar_presentacion(presentacion pen5);
        //-----------------------------proveedor-------------------------------------
        [OperationContract]
        int agregar_proveedor(proveedor pen6);
        [OperationContract]
        int actualizar_proveedor(proveedor pen6);
        [OperationContract]
        int eliminar_proveedor(proveedor pen6);
        [OperationContract]
        List<proveedor> mostrar_proveedor();
        [OperationContract]
        List<proveedor> buscar_proveedor(proveedor pen6);
        //----------------------------------------------------------------------
        [OperationContract]
        int agregar_usuario(Usuario pen7);
        [OperationContract]
        int eliminar_usuario(Usuario pen7);
        [OperationContract]
        int validar_usuario(Usuario pen7);
        [OperationContract]
        List<Usuario> mostrar_usuario_correo(Usuario pen7);
        [OperationContract]
        List<Usuario> mostrar_usuario_id(Int64 pen7);
        [OperationContract]
        int actualizar_usuario(Usuario pen7);
        //---------------------------------sexo------------------------------------
        [OperationContract]
        int agregar_sexo(sexo pen8);
        [OperationContract]
        List<sexo> mostrar_sexo();
        //----------------------------------cargo---------------------------------
        [OperationContract]
        int agregar_cargo(cargo pen9);

        [OperationContract]
        List<cargo> mostrar_cargo();

        //-------------------------------------empleado---------------------------------
        [OperationContract]
        int agregar_empleado(Empleado pen10);
        [OperationContract]
        int actualizar_empleado(Empleado pen10);
        [OperationContract]
        int eliminar_empleado(Empleado pen10);
        [OperationContract]
        List<Empleado> mostrar_empleado();
        [OperationContract]
        int validar_empleado(Empleado pen10);
        //......--------------------------------------- ventas-----------
        [OperationContract]
        int agregar_ventas (ventas pen11);
        [OperationContract]
        List<ventas> mostrar_ventas();
        [OperationContract]
        List<ventas> buscar_ventas(ventas pen11);
    }
}

