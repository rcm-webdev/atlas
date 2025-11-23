import { createRouter, createWebHistory } from 'vue-router'
import Home from '../views/Home.vue'
import Layout from '../layouts/Layout.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: Home,
      meta: { layout: Layout }
    }
  ]
})

export default router

