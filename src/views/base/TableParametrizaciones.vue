<template>
  <CCard>
    <CCardHeader>
      <slot name="header">
        <CIcon name="cil-grid"/> {{caption}}
      </slot>
    </CCardHeader>
    <CCardBody>
      <CDataTable
        :table-filter="fields"
        column-filter
        :sorter="caption"
        :translate="caption"
        :outlined="caption"
        :hover="hover"
        :striped="striped"
        :border="border"
        :small="small"
        :fixed="fixed"
        :items="items"
        :fields="fields"
        :items-per-page="small ? 10 : 5"
        :dark="dark"
        pagination
      >
        <template #evento="{item}">
          <td>
            <CButton
                color="warning"
                size="sm"
                class="m-2"
            >
              Edit.
            </CButton>

            <CButton
                color="danger"
                size="sm"
                class="m-2"
                @click="toggleDetails(item)" >
              Borrar
            </CButton>
          </td>
        </template>
      </CDataTable>
    </CCardBody>
  </CCard>
</template>

<script>
export default {
  name: 'TableParametrizaciones',
  props: {
    items: Array,
    fields: {
      type: Array,
        default () {
         // return ['username', 'registered', 'role', 'status']
         return ['numero_cuenta', 'nombre_cuenta', 'estado_cuenta', 'codigo_transaccion']
      }
    },
    caption: {
      type: String,
      default: 'Table'
    },
    tableFilter:Boolean,
    hover: Boolean,
    striped: Boolean,
    border: Boolean,
    small: Boolean,
    fixed: Boolean,
    dark: Boolean
  },
  methods: {
    getBadge (status) {
      return status === 'Active' ? 'success'
        : status === 'Inactive' ? 'secondary'
          : status === 'Pending' ? 'warning'
            : status === 'Banned' ? 'danger' : 'primary'
    }
  }
}
</script>
