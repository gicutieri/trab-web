<template>
    <div class="Novos-Produtos">
        <div class="container">
            <div class="row">
                <div class="shape">
                    <h2 class="shapecontent">PRODUTOS</h2>
                </div>
            </div>
            <div class="card">
                <div class="card-header">
                    Adicione um novo produto
                </div>
                <div class="card-body">
                    <form class="form-inline" v-on:submit.prevent="onSubmit">
                        <div class="form-group">
                            <label>ID</label>
                            <input type="text" class="form-control ml-sm-2 mr-sm-4 my-2"  required>
                        </div>
                        <div class="form-group">
                            <label>Nome</label>
                            <input  type="text" class="form-control ml-sm-2 mr-sm-4 my-2" required>
                        </div>
                        <div class="form-group">
                            <label>Preço</label>
                            <input  type="text" class="form-control ml-sm-2 mr-sm-4 my-2" required>
                        </div>
                        <div class="form-group">
                            <label>Alt</label>
                            <input  type="text" class="form-control ml-sm-2 mr-sm-4 my-2" required>
                        </div>
                        <div class="form-group">
                            <label>Imagem</label>
                            <input id="filebutton" name="filebutton" class="input-file ml-sm-2 mr-sm-4 my-2" type="file">
                        </div>
                        
                        <div class="ml-auto text-right">
                            <button type="submit" class="btn btn-secondary my-2">Add</button>
                        </div>
                    </form>
                </div>
            </div>
            <div class="card mt-5">
                <div class="card-header">
                    Product List
                </div>
                <div class="card-body">
                    <div class="table-responsive">
                        <table class="table">
                            <thead>
                                <tr>
                                    <th scope="col">
                                         ID
                                    </th>
                                    <th>
                                        NOME
                                    </th>
                                    <th>
                                        PREÇO
                                    </th>
                                    <th>
                                        AÇÃO
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr v-for="product in sortedProducts" v-bind:key="product.id">
                                    <template v-if="editId == product.id">
                                        <td><input v-model="editProductData.product_id" type="text"></td>
                                        <td><input v-model="editProductData.product_name" type="text"></td>
                                        <td><input v-model="editProductData.product_price" type="text"></td>
                                        <td>
                                            <span class="icon">
                                            <i  @click="onEditSubmit(product.id)" class="fa fa-check"></i>
                                            </span>
                                            <span class="icon">
                                            <i  @click="onCancel" class="fa fa-ban"></i>
                                            </span>
                                        </td>
                                    </template>
                                    <template v-else>
                                        <td>
                                            {{product.product_id}}
                                        </td>
                                        <td>
                                            {{product.product_name}}
                                        </td>
                                        <td>
                                            {{product.product_price}}
                                        </td>
                                        <td>
                                            <a href="#" class="icon">
                                            <i v-on:click="onDelete(product.id)" class="fa fa-trash"></i>
                                            </a>
                                            <a href="#" class="icon">
                                            <i v-on:click="onEdit(product)" class="fa fa-pencil"></i>
                                            </a>
                                            <router-link 
                                            :to="{
                                            name:'ProductPage', 
                                            params:{id: product.id}
                                            }" 
                                            class="icon"
                                            >
                                            <i class="fa fa-eye"></i>
                                            </router-link>
                                        </td>
                                    </template>
                                </tr>

                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>


export default {
  name: 'Novos-Produtos',
  components: {
  }
}
</script>

<style scoped>
h3{
  text-align: center;
  margin-top: 30px;
  margin-bottom: 20px;
}
.icon{
  margin-right: 10px;
}
.icon i{
  cursor: pointer;
}
</style>
