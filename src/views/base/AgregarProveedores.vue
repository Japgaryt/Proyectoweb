<template>
  <div>
    <CRow>
      <CCol  md="12">
        <CCard>
          <CCardHeader>
            <strong>Agregar Proveedores</strong> Form
          </CCardHeader>
          <CCardBody>
            <CForm class="row g-3">
              <div class="col-md-6">
                <CInput
                    label="Codigo Poveedor"
                    valid-feedback="Codigo Válido"
                    invalid-feedback="Proporcione al menos 3 caracteres."
                    :is-valid="validator"
                />
              </div>
              <div class="col-md-6">
                <CInput
                    label="Dirección"
                    valid-feedback="Cantidad Válida"
                    invalid-feedback="Proporcione caracteres"
                    :is-valid="validCantProducto"
                    @change="cantidadProducto"
                />
              </div>
              <div class="col-md-6">
                <CInput
                    label="Descripción"
                    valid-feedback="OK!"
                    invalid-feedback="Proporcione al menos 10 caracteres."
                    :is-valid="validDescriptProduct"
                />
              </div>
              <div class="col-md-6">
                <CInput
                    label="Teléfono"
                    valid-feedback="OK!"
                    invalid-feedback="Proporcione al menos 1 número."
                    :is-valid="validCantProducto"
                    @change="valorPrecioUnitario"
                />
              </div>
              <div class="col-md-6">
                <CButton
                    type="submit"
                    size="sm"
                    color="info"
                    @click="enviarDataNuevoProducto"
                >
                  <CIcon name="cil-plus"/>
                  Agregar
                </CButton>

                <CButton type="reset" size="sm" color="danger"><CIcon name="cil-ban"/> Reset</CButton>
              </div>


              <CToaster :autohide="3000">
                <template v-for="toast in fixedToasts">
                  <CToast
                      :key="'toast' + toast"
                      :show="true"
                      color="warning"
                      header="Información"
                  >
                    Debe completar el formulario.
                  </CToast>
                </template>
              </CToaster>
              <CToaster :autohide="2000">
                <template v-for="toast in successToasts">
                  <CToast
                      :key="'toast' + toast"
                      :show="true"
                      color="success"
                      header="Proveedores"
                  >
                   Proveedor agregado correctamente!
                  </CToast>
                </template>
              </CToaster>

            </CForm>
          </CCardBody>
        </CCard>
      </CCol>
    </CRow>

  </div>
</template>

<script>
import axios from "axios";

export default {
  name: 'AgregarProveedores',
  data () {
    return {
      fixedToasts: 0,
      successToasts: 0,
      codigoProducto:0,
      descriptProducto:0,
      cantidadProductos: 0,
      precioUnitario: 0,
      precioTotal:0,
      precioTotalSinFormato:0,
      selected: [], // Must be an array reference!
      show: true,
      horizontal: { label:'col-3', input:'col-9' },
      options: ['Option 1', 'Option 2', 'Option 3'],
      selectOptions: [
        'Option 1', 'Option 2', 'Option 3',
        { 
          value: 'some value', 
          label: 'Selected option'
        }
      ],
      selectedOption: 'some value',

      formCollapsed: true,
      checkboxNames: ['Checkboxes', 'Inline Checkboxes',
                      'Checkboxes - custom', 'Inline Checkboxes - custom'],
      radioNames: ['Radios', 'Inline Radios',
                    'Radios - custom', 'Inline Radios - custom']
    }
  },
  methods: {
    validator (val) {
      this.codigoProducto = val;
      return val ? val.length >= 4 : false
    },
    validDescriptProduct (val) {
      this.descriptProducto = val;
      return val ? val.length >= 10 : false
    },
    validCantProducto(val) {
      return val ? val.length >= 1 : false
    },
    cantidadProducto(val){
      this.cantidadProductos = val;
      this.precioTotalSinFormato = this.cantidadProductos * this.precioUnitario;
      this.precioTotal = new Intl.NumberFormat('en-IN', { maximumSignificantDigits: 3 }).format(this.cantidadProductos * this.precioUnitario)
    },
    valorPrecioUnitario(val){
      this.precioUnitario = val;
      this.precioTotalSinFormato = this.precioUnitario * this.cantidadProductos;
      this.precioTotal = new Intl.NumberFormat('en-IN', { maximumSignificantDigits: 3 }).format(this.precioUnitario * this.cantidadProductos)
    },

    enviarDataNuevoProducto(){
      let dataSent = new Object();
      if((typeof this.codigoProducto == 'undefined' ||  typeof this.descriptProducto == 'undefined') || (  this.cantidadProductos == 0 ||   this.precioUnitario == 0)){
        this.fixedToasts++;
      }else{
        dataSent.codigo_proveedor = this.codigoProducto;
        dataSent.descripcion = this.descriptProducto;
        dataSent.direccion = this.cantidadProductos;
        dataSent.telefono = this.precioUnitario;

        axios.post('https://localhost:44341/api/Proveedores', dataSent)
            .then(resp => {
              this.successToasts++;
              console.log(resp.data);
            });
      }
    }

  }
}


</script>
