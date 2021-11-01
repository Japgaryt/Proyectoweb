export default [
  {
    _name: 'CSidebarNav',
    _children: [
      {
        _name: 'CSidebarNavDropdown',
        name: 'Productos',
        route: '/base',
        icon: 'cil-storage',
        items: [
          {
            name: 'Listado Productos',
            to: '/base/productos'
          },
          {
            name: 'Agregar Producto',
            to: '/base/agregarproductos'
          },
        ]
      },
      {
        _name: 'CSidebarNavDropdown',
        name: 'Provedores',
        route: '/base',
        icon: 'cil-address-book',
        items: [
          {
            name: 'Listado Proveedores',
            to: '/base/proveedores'
          },
          {
            name: 'Agregar Proveedor',
            to: '/base/agregarproveedores'
          },
        ]
      },
      {
        _name: 'CSidebarNavDropdown',
        name: 'Clientes',
        route: '/base',
        icon: 'cil-group',
        items: [
          {
            name: 'Nuevo Cliente',
            to: '/base/agregarclientes'
          },
          {
            name: 'Listado Clientes',
            to: '/base/clientes'
          },
        ]
      },
      {
        _name: 'CSidebarNavDropdown',
        name: 'Facturas',
        route: '/base',
        icon: 'cil-library',
        items: [
          {
            name: 'Nueva Factura',
            to: '/base/nuevafactura'
          },
          {
            name: 'Listado Facturas',
            to: '/base/parametrizacion'
          },
        ]
      },

      {
        _name: 'CSidebarNavDropdown',
        name: 'Movimientos Contables',
        route: '/base',
        icon: 'cil-window-restore',
        items: [
          {
            name: 'Parametrización',
            to: '/base/parametrizacion'
          },
          {
            name: 'Partidas Contables',
            to: '/base/asientoscontables'
          },
          {
            name: 'Diario Mayor General',
            to: '/base/diariomayorgeneral'
          },
          {
            name: 'Estado de Resultados',
            to: '/base/estadoderesultados'
          },
          {
            name: 'Balance de Saldos',
            to: '/base/balancedesaldos',
          },
          ]
      },
    ]
  }
]