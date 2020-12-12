import Vue from 'vue'
import VueRouter from 'vue-router'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: () => import("@/views/Home"),
    meta: { title: 'YBY - Home' }
  },
  {
    path: '/loja',
    name: 'Loja',
    component: () => import("@/views/Loja"),
    meta: { title: 'YBY - Loja' }
  },
  {
    path: '/sobre',
    name: 'Sobre',
    component: () => import("@/views/Sobre"),
    meta: { title: 'YBY - Sobre' }
  },
  {
    path: '/carrinho',
    name: 'Carrinho',
    component: () => import("@/views/Carrinho"),
    meta: { title: 'YBY - Carrinho' }
  },
  {
    path: '/conta',
    name: 'Conta',
    component: () => import("@/views/Conta"),
    meta: { title: 'YBY - Conta' }
  },
  {
    path: '/cadastro',
    name: 'Cadastro',
    component: () => import("@/views/Cadastro"),
    meta: { title: 'YBY - Cadastro' }
  },
  {
    path: '/minha-conta',
    name: 'Minha-conta',
    component: () => import("@/views/Minha-conta"),
    meta: { title: 'YBY - Minha Conta' }
  },
  {
    path: '/login',
    name: 'Login',
    component: () => import("@/views/Login"),
    meta: { title: 'YBY - Login' }
  },
  {
    path: '/novosprodutos',
    name: 'Novos-Produtos',
    component: () => import("@/views/Novos-Produtos"),
    meta: { title: 'YBY - Novos Produtos' }
  },
  {
    path: '/pagamento',
    name: 'Pagamento',
    component: () => import("@/views/Pagamento"),
    meta: { title: 'YBY - Pagamento' }
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

router.beforeEach((toRoute, fromRoute, next) => {
  window.document.title = toRoute.meta && toRoute.meta.title ? toRoute.meta.title : 'Hortifruti';
  next();
})

export default router
