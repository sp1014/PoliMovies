import Vue from 'vue'
import VueRouter from 'vue-router'
import movieInfo from '../views/movieInfo.vue'
import frontPage from '../views/frontPage.vue'
import login from '../views/login.vue'
import createdUser from '../views/createdUser.vue'
import ensayos from '../views/ensayos.vue'
import createdMovies from '../views/createdMovies.vue'
import newMovie from '../views/newMovie.vue'
import movie from '../views/movie.vue'
import PQR from '../views/PQR.vue'


Vue.use(VueRouter)

const routes = [{
        path: '/',
        name: 'frontPage',
        component: frontPage
    },
    {
        path: '/movieInfo',
        name: 'movieInfo',
        component: movieInfo
    }, {
        path: '/createdUser',
        name: 'createdUser',
        component: createdUser

    },
    {
        path: '/login',
        name: 'login',
        component: login,
    },
    {
        path: '/ensayos',
        name: 'ensayos',
        component: ensayos,
    },
    {
        path: '/createdMovies',
        name: 'createdMovies',
        component: createdMovies,
    },
    {
        path: '/newMovie',
        name: 'newMovie',
        component: newMovie
    },
    {
        path: '/movie',
        name: 'movie',
        component: movie
    },
    {
        path: '/PQR',
        name: 'PQRe',
        component: PQR
    },


]

const router = new VueRouter({
    routes
})

export default router