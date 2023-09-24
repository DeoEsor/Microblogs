import Auth from '@/views/Auth.vue'
import Feed from '@/views/Feed.vue'
import { createRouter, createWebHistory } from "vue-router"



const routes = [
    {path: '/Auth', name: 'Auth', component: Auth },
    
    {path: '/Feed', name: 'Feed', component: Feed },
]

const router = createRouter({
    history: createWebHistory(),

    routes
})

export default router