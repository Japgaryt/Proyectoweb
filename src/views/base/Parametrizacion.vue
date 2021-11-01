<template>
  <div>
    <CRow>
      <CCol sm="8">
        <CCard>
          <CCardHeader>
            <strong>Credit Card </strong> <small>Form</small>
            <div class="card-header-actions">
              <a
                href="https://coreui.io/vue/docs/components/form-components"
                class="card-header-action"
                rel="noreferrer noopener"
                target="_blank"
              >
                <small class="text-muted">docs</small>
              </a>
            </div>
          </CCardHeader>
          <CCardBody>
            <CRow>
              <CCol sm="12">
                <CTableWrapper
                    :items="getShuffledUsersData()"
                    hover
                    striped
                    border
                    table-filter
                    small
                    fixed
                    caption="Parametrizaciones"
                />
              </CCol>
            </CRow>
          </CCardBody>
        </CCard>
      </CCol>
      <CCol sm="4">
        <CCard>
          <CCardHeader>
            <strong>Parametrizaciones </strong><small>Form</small>
          </CCardHeader>
          <CCardBody>
            <CInput
              label="Número de Cuenta"
              valid-feedback="Codigo Válido"
              placeholder="Numero de cuenta"
              :is-valid="numeroCuenta"
            />
            <CInput
              label="Nombre de la Cuenta"
              placeholder="Nombre de cuenta"
              :is-valid="nombreCuenta"
            />

            <CInput
                label="Código transacción"
                placeholder="Código"
                :is-valid="codTransaction"
            />
            <CButton
                type="submit"
                size="sm"
                color="info"
                @click="enviarDataNuevoProducto">
              <CIcon name="cil-plus"/>
              Agregar
            </CButton>
          </CCardBody>
        </CCard>
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
                header="Productos"
            >
              Producto agregado correctamente!
            </CToast>
          </template>
        </CToaster>
      </CCol>
    </CRow>
  </div>
</template>

<script>
import CTableWrapper from './TableParametrizaciones'
import axios from "axios";

export default {
  name: 'Parametrizacion',
  components: { CTableWrapper },
  data () {
    return {
      fixedToasts: 0,
      numero_cuenta:0,
      nombre_cuenta:0,
      cod_transaction:0,
      productos: null,
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
  }
  ,mounted () {
    axios.get('https://localhost:44341/api/Parametrizaciones')
        .then(resp => {
          this.productos = resp.data
          console.log(resp.data);
        });
  },
  methods: {
    numeroCuenta (val) {
      this.numero_cuenta =val;
      return val ? val.length >= 4 : false
    },

    nombreCuenta (val) {
      this.nombre_cuenta = val;
      return val ? val.length >= 10 : false
    },

    getShuffledUsersData () {
      return this.productos
    },
    codTransaction(val){
      this.cod_transaction = val;

    },

    enviarDataNuevoProducto(){
       let dataSent = new Object();
       if((typeof this.nombre_cuenta == 'undefined' )){
        this.fixedToasts++;
      }else{
        dataSent.numero_cuenta = parseInt(this.numero_cuenta);
        dataSent.nombre_cuenta = this.nombre_cuenta;
        dataSent.estado_cuenta = 1;
        dataSent.codigo_transaccion = this.cod_transaction;

        console.log(dataSent);
          axios.post('https://localhost:44341/api/Parametrizaciones', dataSent)
            .then(resp => {
              this.successToasts++;
              console.log(resp.data);
            }) ;
      }
    },


  }
}
</script>
