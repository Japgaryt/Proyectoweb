<template>
  <div>
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
          caption="Listado de Proveedores"
        />
      </CCol>
    </CRow>
  </div>
</template>

<script>
import CTableWrapper from './TableProveedores'
import axios from "axios";
export default {
  data () {
    return {
      productos: null
    }
  },
  mounted () {
    axios.get('https://localhost:44341/api/Proveedores')
        .then(resp => {this.productos = resp.data});
  },
  name: 'Productos',
  tableFilter:true,
  components: { CTableWrapper },
  methods: {
    getShuffledUsersData () {
      return this.productos
    }
  }
}
</script>
