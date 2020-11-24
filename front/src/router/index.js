import Vue from 'vue'
import VueRouter from 'vue-router'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: () => import("@/views/Home"),
    meta: { title: 'Hortifruti - Home' }
  },
  {
    path: '/loja',
    name: 'Loja',
    component: () => import("@/views/Loja"),
    meta: { title: 'Hortifruti - Loja' }
  },
  {
    path: '/sobre',
    name: 'Sobre',
    component: () => import("@/views/Sobre"),
    meta: { title: 'Hortifruti - Sobre' }
  },
  {
    path: '/carrinho',
    name: 'Carrinho',
    component: () => import("@/views/Carrinho"),
    meta: { title: 'Hortifruti - Carrinho' }
  },
  {
    path: '/conta',
    name: 'Conta',
    component: () => import("@/views/Conta"),
    meta: { title: 'Hortifruti - Conta' }
  },
  {
    path: '/cadastro',
    name: 'Cadastro',
    component: () => import("@/views/Cadastro"),
    meta: { title: 'Hortifruti - Cadastro' }
  },
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
